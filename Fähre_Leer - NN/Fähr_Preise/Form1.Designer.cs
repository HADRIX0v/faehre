using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Fähr_Preise
{
    [DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTyp = new System.Windows.Forms.ComboBox();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this._btnSchliesse = new System.Windows.Forms.Button();
            this._btnBerechne = new System.Windows.Forms.Button();
            this.lblPassagiere = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSumme = new System.Windows.Forms.Label();
            this.lstProtokoll = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboTyp);
            this.GroupBox1.Controls.Add(this.txtAnzahl);
            this.GroupBox1.Controls.Add(this._btnSchliesse);
            this.GroupBox1.Controls.Add(this._btnBerechne);
            this.GroupBox1.Controls.Add(this.lblPassagiere);
            this.GroupBox1.Controls.Add(this.lblTyp);
            this.GroupBox1.Location = new System.Drawing.Point(30, 24);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(388, 152);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Eingabe";
            // 
            // cboTyp
            // 
            this.cboTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTyp.FormattingEnabled = true;
            this.cboTyp.Location = new System.Drawing.Point(136, 20);
            this.cboTyp.Name = "cboTyp";
            this.cboTyp.Size = new System.Drawing.Size(129, 21);
            this.cboTyp.TabIndex = 7;
            this.cboTyp.SelectedIndexChanged += new System.EventHandler(this.cboTyp_SelectedIndexChanged);
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(136, 90);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(130, 20);
            this.txtAnzahl.TabIndex = 6;
            // 
            // _btnSchliesse
            // 
            this._btnSchliesse.Location = new System.Drawing.Point(278, 83);
            this._btnSchliesse.Name = "_btnSchliesse";
            this._btnSchliesse.Size = new System.Drawing.Size(94, 32);
            this._btnSchliesse.TabIndex = 5;
            this._btnSchliesse.Text = "Schliesse";
            this._btnSchliesse.UseVisualStyleBackColor = true;
            this._btnSchliesse.Click += new System.EventHandler(this.btnSchliesse_Click);
            // 
            // _btnBerechne
            // 
            this._btnBerechne.Location = new System.Drawing.Point(278, 19);
            this._btnBerechne.Name = "_btnBerechne";
            this._btnBerechne.Size = new System.Drawing.Size(94, 32);
            this._btnBerechne.TabIndex = 4;
            this._btnBerechne.Text = "Berechne";
            this._btnBerechne.UseVisualStyleBackColor = true;
            this._btnBerechne.Click += new System.EventHandler(this.btnBerechne_Click);
            // 
            // lblPassagiere
            // 
            this.lblPassagiere.AutoSize = true;
            this.lblPassagiere.Location = new System.Drawing.Point(21, 93);
            this.lblPassagiere.Name = "lblPassagiere";
            this.lblPassagiere.Size = new System.Drawing.Size(94, 13);
            this.lblPassagiere.TabIndex = 1;
            this.lblPassagiere.Text = "Anzahl Passagiere";
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(21, 25);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(65, 13);
            this.lblTyp.TabIndex = 0;
            this.lblTyp.Text = "Fahrzeugtyp";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblAusgabe);
            this.GroupBox2.Location = new System.Drawing.Point(35, 192);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(382, 116);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Ausgabe";
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgabe.Location = new System.Drawing.Point(19, 32);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(111, 24);
            this.lblAusgabe.TabIndex = 0;
            this.lblAusgabe.Text = "Ausgabe...";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lblSumme);
            this.GroupBox3.Controls.Add(this.lstProtokoll);
            this.GroupBox3.Location = new System.Drawing.Point(448, 33);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(142, 274);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Protokoll";
            // 
            // lblSumme
            // 
            this.lblSumme.AutoSize = true;
            this.lblSumme.Location = new System.Drawing.Point(27, 247);
            this.lblSumme.Name = "lblSumme";
            this.lblSumme.Size = new System.Drawing.Size(52, 13);
            this.lblSumme.TabIndex = 1;
            this.lblSumme.Text = "lblSumme";
            // 
            // lstProtokoll
            // 
            this.lstProtokoll.FormattingEnabled = true;
            this.lstProtokoll.Location = new System.Drawing.Point(23, 25);
            this.lstProtokoll.Name = "lstProtokoll";
            this.lstProtokoll.Size = new System.Drawing.Size(100, 212);
            this.lstProtokoll.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 356);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Fährpreise berechnen";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        internal GroupBox GroupBox1;
        internal Label lblPassagiere;
        internal Label lblTyp;
        internal GroupBox GroupBox2;
        private Button _btnSchliesse;

        internal Button btnSchliesse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSchliesse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSchliesse != null)
                {
                    _btnSchliesse.Click -= btnSchliesse_Click;
                }

                _btnSchliesse = value;
                if (_btnSchliesse != null)
                {
                    _btnSchliesse.Click += btnSchliesse_Click;
                }
            }
        }

        private Button _btnBerechne;

        internal Button btnBerechne
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnBerechne;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnBerechne != null)
                {
                    _btnBerechne.Click -= btnBerechne_Click;
                }

                _btnBerechne = value;
                if (_btnBerechne != null)
                {
                    _btnBerechne.Click += btnBerechne_Click;
                }
            }
        }

        internal Label lblAusgabe;
        internal TextBox txtAnzahl;
        internal ComboBox cboTyp;
        internal GroupBox GroupBox3;
        internal Label lblSumme;
        internal ListBox lstProtokoll;
    }
}