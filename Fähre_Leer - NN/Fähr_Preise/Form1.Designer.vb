<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTyp = New System.Windows.Forms.ComboBox()
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.btnSchliesse = New System.Windows.Forms.Button()
        Me.btnBerechne = New System.Windows.Forms.Button()
        Me.lblPassagiere = New System.Windows.Forms.Label()
        Me.lblTyp = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAusgabe = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSumme = New System.Windows.Forms.Label()
        Me.lstProtokoll = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTyp)
        Me.GroupBox1.Controls.Add(Me.txtAnzahl)
        Me.GroupBox1.Controls.Add(Me.btnSchliesse)
        Me.GroupBox1.Controls.Add(Me.btnBerechne)
        Me.GroupBox1.Controls.Add(Me.lblPassagiere)
        Me.GroupBox1.Controls.Add(Me.lblTyp)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eingabe"
        '
        'cboTyp
        '
        Me.cboTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTyp.FormattingEnabled = True
        Me.cboTyp.Location = New System.Drawing.Point(136, 20)
        Me.cboTyp.Name = "cboTyp"
        Me.cboTyp.Size = New System.Drawing.Size(129, 21)
        Me.cboTyp.TabIndex = 7
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Location = New System.Drawing.Point(136, 90)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(130, 20)
        Me.txtAnzahl.TabIndex = 6
        '
        'btnSchliesse
        '
        Me.btnSchliesse.Location = New System.Drawing.Point(278, 83)
        Me.btnSchliesse.Name = "btnSchliesse"
        Me.btnSchliesse.Size = New System.Drawing.Size(94, 32)
        Me.btnSchliesse.TabIndex = 5
        Me.btnSchliesse.Text = "Schliesse"
        Me.btnSchliesse.UseVisualStyleBackColor = True
        '
        'btnBerechne
        '
        Me.btnBerechne.Location = New System.Drawing.Point(278, 19)
        Me.btnBerechne.Name = "btnBerechne"
        Me.btnBerechne.Size = New System.Drawing.Size(94, 32)
        Me.btnBerechne.TabIndex = 4
        Me.btnBerechne.Text = "Berechne"
        Me.btnBerechne.UseVisualStyleBackColor = True
        '
        'lblPassagiere
        '
        Me.lblPassagiere.AutoSize = True
        Me.lblPassagiere.Location = New System.Drawing.Point(21, 93)
        Me.lblPassagiere.Name = "lblPassagiere"
        Me.lblPassagiere.Size = New System.Drawing.Size(94, 13)
        Me.lblPassagiere.TabIndex = 1
        Me.lblPassagiere.Text = "Anzahl Passagiere"
        '
        'lblTyp
        '
        Me.lblTyp.AutoSize = True
        Me.lblTyp.Location = New System.Drawing.Point(21, 25)
        Me.lblTyp.Name = "lblTyp"
        Me.lblTyp.Size = New System.Drawing.Size(65, 13)
        Me.lblTyp.TabIndex = 0
        Me.lblTyp.Text = "Fahrzeugtyp"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAusgabe)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 116)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabe"
        '
        'lblAusgabe
        '
        Me.lblAusgabe.AutoSize = True
        Me.lblAusgabe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAusgabe.Location = New System.Drawing.Point(19, 32)
        Me.lblAusgabe.Name = "lblAusgabe"
        Me.lblAusgabe.Size = New System.Drawing.Size(111, 24)
        Me.lblAusgabe.TabIndex = 0
        Me.lblAusgabe.Text = "Ausgabe..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSumme)
        Me.GroupBox3.Controls.Add(Me.lstProtokoll)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 274)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Protokoll"
        '
        'lblSumme
        '
        Me.lblSumme.AutoSize = True
        Me.lblSumme.Location = New System.Drawing.Point(27, 247)
        Me.lblSumme.Name = "lblSumme"
        Me.lblSumme.Size = New System.Drawing.Size(52, 13)
        Me.lblSumme.TabIndex = 1
        Me.lblSumme.Text = "lblSumme"
        '
        'lstProtokoll
        '
        Me.lstProtokoll.FormattingEnabled = True
        Me.lstProtokoll.Location = New System.Drawing.Point(23, 25)
        Me.lstProtokoll.Name = "lstProtokoll"
        Me.lstProtokoll.Size = New System.Drawing.Size(100, 212)
        Me.lstProtokoll.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 356)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Fährpreise berechnen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassagiere As System.Windows.Forms.Label
    Friend WithEvents lblTyp As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSchliesse As System.Windows.Forms.Button
    Friend WithEvents btnBerechne As System.Windows.Forms.Button
    Friend WithEvents lblAusgabe As System.Windows.Forms.Label
    Friend WithEvents txtAnzahl As System.Windows.Forms.TextBox
    Friend WithEvents cboTyp As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSumme As System.Windows.Forms.Label
    Friend WithEvents lstProtokoll As System.Windows.Forms.ListBox

End Class
