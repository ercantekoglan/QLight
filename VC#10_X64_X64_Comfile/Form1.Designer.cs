namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.turn_off_lights = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.passed_light = new System.Windows.Forms.Button();
            this.failed_light = new System.Windows.Forms.Button();
            this.processing_light = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read_State";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lamp_wrtie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // turn_off_lights
            // 
            this.turn_off_lights.Location = new System.Drawing.Point(221, 246);
            this.turn_off_lights.Name = "turn_off_lights";
            this.turn_off_lights.Size = new System.Drawing.Size(75, 39);
            this.turn_off_lights.TabIndex = 2;
            this.turn_off_lights.Text = "All Clear";
            this.turn_off_lights.UseVisualStyleBackColor = true;
            this.turn_off_lights.Click += new System.EventHandler(this.button7_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(90, 95);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(359, 20);
            this.text1.TabIndex = 4;
            // 
            // passed_light
            // 
            this.passed_light.Location = new System.Drawing.Point(221, 157);
            this.passed_light.Name = "passed_light";
            this.passed_light.Size = new System.Drawing.Size(75, 39);
            this.passed_light.TabIndex = 5;
            this.passed_light.Text = "PASSED";
            this.passed_light.UseVisualStyleBackColor = true;
            this.passed_light.Click += new System.EventHandler(this.button5_Click);
            // 
            // failed_light
            // 
            this.failed_light.Location = new System.Drawing.Point(342, 157);
            this.failed_light.Name = "failed_light";
            this.failed_light.Size = new System.Drawing.Size(75, 39);
            this.failed_light.TabIndex = 6;
            this.failed_light.Text = "FAILED";
            this.failed_light.UseVisualStyleBackColor = true;
            this.failed_light.Click += new System.EventHandler(this.button4_Click);

            // 
            // processing_light
            // 
            this.processing_light.Location = new System.Drawing.Point(90, 157);
            this.processing_light.Name = "processing_light";
            this.processing_light.Size = new System.Drawing.Size(75, 39);
            this.processing_light.TabIndex = 7;
            this.processing_light.Text = "Processing";
            this.processing_light.UseVisualStyleBackColor = true;
            this.processing_light.Click += new System.EventHandler(this.button6_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 298);
            this.Controls.Add(this.processing_light);
            this.Controls.Add(this.failed_light);
            this.Controls.Add(this.passed_light);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.turn_off_lights);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "C#_usb_x64_x64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button turn_off_lights;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button passed_light;
        private System.Windows.Forms.Button failed_light;
        private System.Windows.Forms.Button processing_light;
    }
}

