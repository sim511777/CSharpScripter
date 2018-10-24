namespace CSharpScripter {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnLoad = new System.Windows.Forms.Button();
         this.btnRun = new System.Windows.Forms.Button();
         this.tbxRun = new System.Windows.Forms.TextBox();
         this.pnlEditor = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.pnlEditor);
         this.splitContainer1.Panel1.Controls.Add(this.panel1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.tbxRun);
         this.splitContainer1.Size = new System.Drawing.Size(1130, 718);
         this.splitContainer1.SplitterDistance = 520;
         this.splitContainer1.TabIndex = 0;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnClear);
         this.panel1.Controls.Add(this.btnSave);
         this.panel1.Controls.Add(this.btnLoad);
         this.panel1.Controls.Add(this.btnRun);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 482);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1130, 38);
         this.panel1.TabIndex = 0;
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(255, 6);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(75, 23);
         this.btnClear.TabIndex = 0;
         this.btnClear.Text = "Clear";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(12, 6);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnLoad
         // 
         this.btnLoad.Location = new System.Drawing.Point(93, 6);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.Size = new System.Drawing.Size(75, 23);
         this.btnLoad.TabIndex = 0;
         this.btnLoad.Text = "Load";
         this.btnLoad.UseVisualStyleBackColor = true;
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
         // 
         // btnRun
         // 
         this.btnRun.Location = new System.Drawing.Point(174, 6);
         this.btnRun.Name = "btnRun";
         this.btnRun.Size = new System.Drawing.Size(75, 23);
         this.btnRun.TabIndex = 0;
         this.btnRun.Text = "Run";
         this.btnRun.UseVisualStyleBackColor = true;
         this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
         // 
         // tbxRun
         // 
         this.tbxRun.BackColor = System.Drawing.SystemColors.Window;
         this.tbxRun.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxRun.Font = new System.Drawing.Font("굴림체", 9F);
         this.tbxRun.Location = new System.Drawing.Point(0, 0);
         this.tbxRun.Multiline = true;
         this.tbxRun.Name = "tbxRun";
         this.tbxRun.ReadOnly = true;
         this.tbxRun.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.tbxRun.Size = new System.Drawing.Size(1130, 194);
         this.tbxRun.TabIndex = 2;
         // 
         // pnlEditor
         // 
         this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pnlEditor.Location = new System.Drawing.Point(0, 0);
         this.pnlEditor.Name = "pnlEditor";
         this.pnlEditor.Size = new System.Drawing.Size(1130, 482);
         this.pnlEditor.TabIndex = 1;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1130, 718);
         this.Controls.Add(this.splitContainer1);
         this.Name = "FormMain";
         this.Text = "C# Scripter";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnRun;
      private System.Windows.Forms.TextBox tbxRun;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnLoad;
      private System.Windows.Forms.Panel pnlEditor;
   }
}

