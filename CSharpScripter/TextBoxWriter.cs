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

        private void TbxAppendTextSafe(string text) {
            Action action = () => this.tbx.AppendText(text);
            if (this.tbx.InvokeRequired) {
                this.tbx.Invoke(action);
            } else {
                action();
            }
        }

        public override void Write(string format, params object[] arg) {
            this.TbxAppendTextSafe(string.Format(format, arg));
        }
        public override void Write(string format, object arg0, object arg1, object arg2) {
            this.TbxAppendTextSafe(string.Format(format, arg0, arg1, arg2));
        }
        public override void Write(string format, object arg0, object arg1) {
            this.TbxAppendTextSafe(string.Format(format, arg0, arg1));
        }
        public override void Write(object value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(string value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(decimal value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(string format, object arg0) {
            this.TbxAppendTextSafe(string.Format(format, arg0));
        }
        public override void Write(float value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(ulong value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(long value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(uint value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(int value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(bool value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(char[] buffer, int index, int count) {
            this.TbxAppendTextSafe(new string(buffer, index, count));
        }
        public override void Write(char[] buffer) {
            this.TbxAppendTextSafe(new string(buffer));
        }
        public override void Write(double value) {
            this.TbxAppendTextSafe(value.ToString());
        }
        public override void Write(char value) {
            this.TbxAppendTextSafe(value.ToString());
        }

        public override void WriteLine(string format, object arg0) {
            this.TbxAppendTextSafe(string.Format(format, arg0) + Environment.NewLine);
        }
        public override void WriteLine(string format, params object[] arg) {
            this.TbxAppendTextSafe(string.Format(format, arg) + Environment.NewLine);
        }
        public override void WriteLine(string format, object arg0, object arg1, object arg2) {
            this.TbxAppendTextSafe(string.Format(format, arg0, arg1, arg2) + Environment.NewLine);
        }
        public override void WriteLine(string format, object arg0, object arg1) {
            this.TbxAppendTextSafe(string.Format(format, arg0, arg1) + Environment.NewLine);
        }
        public override void WriteLine(object value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(int value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(decimal value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine() {
            this.TbxAppendTextSafe(Environment.NewLine);
        }
        public override void WriteLine(char value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(string value) {
            this.TbxAppendTextSafe(value + Environment.NewLine);
        }
        public override void WriteLine(char[] buffer, int index, int count) {
            this.TbxAppendTextSafe(new string(buffer, index, count) + Environment.NewLine);
        }
        public override void WriteLine(bool value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(char[] buffer) {
            this.TbxAppendTextSafe(new string(buffer) + Environment.NewLine);
        }
        public override void WriteLine(long value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(ulong value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(float value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(double value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
        public override void WriteLine(uint value) {
            this.TbxAppendTextSafe(value.ToString() + Environment.NewLine);
        }
    }
}
