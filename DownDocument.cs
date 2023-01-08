using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWolf
{
    public class DownDocument
    {
        private List<DownDocumentItem> doc = new();
        public DownDocument()
        {

        }

        public DownDocument(string document)
        {
            document = document.Replace("\r\n", "\n").Replace('\r', '\n');
            AppendFromLines(document.Split('\n'));
        }

        public DownDocument(string[] document)
        {
            AppendFromLines(document);
        }

        public void AppendFromLines(string[] lines)
        {
            DownDocumentItem? codeBlock=null;
            int listblock = 0;
            foreach (string ln in lines)
            {
                if (codeBlock != null)
                {
                    if (ln.StartsWith("```"))
                    {
                        doc.Add(codeBlock);
                        codeBlock = null;
                        continue;
                    }
                    codeBlock.Text = codeBlock.Text + "\n" + ln;
                }
                if (ln.StartsWith("###"))
                    doc.Add(new DownDocumentItem(ln[3..].Trim(), DownDocumentType.TirdTitle));
                if (ln.StartsWith("##"))
                    doc.Add(new DownDocumentItem(ln[2..].Trim(), DownDocumentType.Subtitle));
                if (ln.StartsWith("#"))
                    doc.Add(new DownDocumentItem(ln[1..].Trim(), DownDocumentType.Title));
                if (ln.StartsWith(">"))
                    doc.Add(new DownDocumentItem(ln[1..].Trim(), DownDocumentType.Quote));
                if (ln.StartsWith("*"))
                {
                    listblock++;
                    doc.Add(new DownDocumentItem(ln[1..].Trim(), DownDocumentType.Quote)
                    {
                        ListNumber = listblock
                    });
                }
                else
                {
                    listblock = 0;
                }
                if (ln.StartsWith("```"))
                {
                    string l = ln[3..].Trim();
                    string? lang=null;
                    if (l.Length > 0 && l[0] == '[')
                    {
                        int dp = l.IndexOf(']');
                        if (dp > 0)
                            lang = l[1..dp];
                    }
                    codeBlock = new DownDocumentItem(DownDocumentType.Code)
                    {
                        CodeLanguage = lang
                    };
                }
            }
        }

        public void Clear()
        {
            doc.Clear();
        }
    }

    public class DownDocumentItem
    {

        public DownDocumentItem(DownDocumentType type)
        {
            Text = "";
            Type = type;
        }
        public DownDocumentItem(string text, DownDocumentType type)
        {
            Text = text;
            Type = type;
        }

        public string Text { get; set; }
        public DownDocumentType Type { get; private set; } = DownDocumentType.Normal;
        public string? CodeLanguage { get; set; }
        public int ListNumber { get; set; }
    }

    public enum DownDocumentType
    {
        Normal,TirdTitle,Subtitle,Title,Quote,Code,List
    }
}
