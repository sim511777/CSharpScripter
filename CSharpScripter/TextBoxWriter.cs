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

      public override void Write(string format, params object[] arg){
         tbx.AppendText(string.Format(format, arg));
      }
      public override void Write(string format, object arg0, object arg1, object arg2){
         tbx.AppendText(string.Format(format, arg0, arg1, arg2));
      }
      public override void Write(string format, object arg0, object arg1){
         tbx.AppendText(string.Format(format, arg0, arg1));
      }
      public override void Write(object value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(string value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(decimal value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(string format, object arg0){
         tbx.AppendText(string.Format(format, arg0));
      }
      public override void Write(float value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(ulong value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(long value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(uint value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(int value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(bool value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(char[] buffer, int index, int count){
         tbx.AppendText(new string(buffer, index, count));
      }
      public override void Write(char[] buffer){
         tbx.AppendText(new string(buffer));
      }
      public override void Write(double value){
         tbx.AppendText(value.ToString());
      }
      public override void Write(char value) {
         tbx.AppendText(value.ToString());
      }

      public override void WriteLine(string format, object arg0){
         tbx.AppendText(string.Format(format, arg0) + Environment.NewLine);
      }
      public override void WriteLine(string format, params object[] arg){
         tbx.AppendText(string.Format(format, arg) + Environment.NewLine);
      }
      public override void WriteLine(string format, object arg0, object arg1, object arg2){
         tbx.AppendText(string.Format(format, arg0, arg1, arg2) + Environment.NewLine);
      }
      public override void WriteLine(string format, object arg0, object arg1){
         tbx.AppendText(string.Format(format, arg0, arg1) + Environment.NewLine);
      }
      public override void WriteLine(object value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(int value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(decimal value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(){
         tbx.AppendText(Environment.NewLine);
      }
      public override void WriteLine(char value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(string value){
         tbx.AppendText(value + Environment.NewLine);
      }
      public override void WriteLine(char[] buffer, int index, int count){
         tbx.AppendText(new string(buffer, index, count) + Environment.NewLine);
      }
      public override void WriteLine(bool value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(char[] buffer){
         tbx.AppendText(new string(buffer) + Environment.NewLine);
      }
      public override void WriteLine(long value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(ulong value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(float value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(double value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
      public override void WriteLine(uint value){
         tbx.AppendText(value.ToString() + Environment.NewLine);
      }
   }
}
