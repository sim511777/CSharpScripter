using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharpScripter {
public class TextBoxWriter : TextWriter {
      private TextBox tbx;
      public TextBoxWriter(TextBox tbx) {
         this.tbx = tbx;
      }

      public override Encoding Encoding {
         get { return Encoding.Default; }
      }

      public override void Write(char value) {
         tbx.AppendText(value.ToString());
      }
   }
}
