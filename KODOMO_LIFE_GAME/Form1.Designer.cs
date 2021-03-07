
namespace KODOMO_LIFE_GAME
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.moneyInMyPocket1 = new KODOMO_LIFE_GAME.MoneyInMyPocket();
            this.moneyInMyPocket2 = new KODOMO_LIFE_GAME.MoneyInMyPocket();
            this.moneyInMyPocket3 = new KODOMO_LIFE_GAME.MoneyInMyPocket();
            this.SuspendLayout();
            // 
            // moneyInMyPocket1
            // 
            this.moneyInMyPocket1.Location = new System.Drawing.Point(12, 12);
            this.moneyInMyPocket1.Name = "moneyInMyPocket1";
            this.moneyInMyPocket1.Size = new System.Drawing.Size(304, 460);
            this.moneyInMyPocket1.TabIndex = 0;
            // 
            // moneyInMyPocket2
            // 
            this.moneyInMyPocket2.Location = new System.Drawing.Point(357, 12);
            this.moneyInMyPocket2.Name = "moneyInMyPocket2";
            this.moneyInMyPocket2.Size = new System.Drawing.Size(306, 449);
            this.moneyInMyPocket2.TabIndex = 1;
            // 
            // moneyInMyPocket3
            // 
            this.moneyInMyPocket3.Location = new System.Drawing.Point(720, 12);
            this.moneyInMyPocket3.Name = "moneyInMyPocket3";
            this.moneyInMyPocket3.Size = new System.Drawing.Size(306, 449);
            this.moneyInMyPocket3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 470);
            this.Controls.Add(this.moneyInMyPocket3);
            this.Controls.Add(this.moneyInMyPocket2);
            this.Controls.Add(this.moneyInMyPocket1);
            this.Name = "Form1";
            this.Text = "KODOMO新聞版人生ゲーム";
            this.ResumeLayout(false);

        }

        #endregion

        private MoneyInMyPocket moneyInMyPocket1;
        private MoneyInMyPocket moneyInMyPocket2;
        private MoneyInMyPocket moneyInMyPocket3;
    }
}

