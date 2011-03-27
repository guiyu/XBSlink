﻿/**
 * Project: XBSlink: A XBox360 & PS3/2 System Link Proxy
 * File name: DebugWindow.Designer.cs
 *   
 * @author Oliver Seuffert, Copyright (C) 2011.
 */
/* 
 * XBSlink is free software; you can redistribute it and/or modify 
 * it under the terms of the GNU General Public License as published by 
 * the Free Software Foundation; either version 2 of the License, or 
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful, but 
 * WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
 * or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
 * for more details.
 * 
 * You should have received a copy of the GNU General Public License along 
 * with this program; If not, see <http://www.gnu.org/licenses/>
 */

namespace XBSlink
{
    partial class DebugWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_clear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView_messages = new System.Windows.Forms.ListView();
            this.columnHeader_message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_message2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView_messages
            // 
            this.listView_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_message,
            this.columnHeader_message2});
            this.listView_messages.Location = new System.Drawing.Point(12, 41);
            this.listView_messages.Name = "listView_messages";
            this.listView_messages.Size = new System.Drawing.Size(616, 427);
            this.listView_messages.TabIndex = 3;
            this.listView_messages.UseCompatibleStateImageBehavior = false;
            this.listView_messages.View = System.Windows.Forms.View.Details;
            this.listView_messages.Resize += new System.EventHandler(this.listView_Resize);
            // 
            // columnHeader_message
            // 
            this.columnHeader_message.Text = "Messages";
            this.columnHeader_message.Width = 550;
            // 
            // columnHeader_message2
            // 
            this.columnHeader_message2.Text = "";
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.listView_messages);
            this.Controls.Add(this.button_clear);
            this.Name = "DebugWindow";
            this.Text = "Debug Messages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugWindow_FormClosing);
            this.Load += new System.EventHandler(this.DebugWindows_Load);
            this.SizeChanged += new System.EventHandler(this.DebugWindow_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView_messages;
        private System.Windows.Forms.ColumnHeader columnHeader_message;
        private System.Windows.Forms.ColumnHeader columnHeader_message2;
    }
}