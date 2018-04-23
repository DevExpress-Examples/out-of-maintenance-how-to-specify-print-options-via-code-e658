Imports Microsoft.VisualBasic
Imports System
Namespace PrintAppointmentsInInterval
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New PrintAppointmentsInInterval.CarsDBDataSet()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.timeEdit2 = New DevExpress.XtraEditors.TimeEdit()
			Me.timeEdit1 = New DevExpress.XtraEditors.TimeEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
			Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.carSchedulingTableAdapter = New PrintAppointmentsInInterval.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
			Me.carsTableAdapter = New PrintAppointmentsInInterval.CarsDBDataSetTableAdapters.CarsTableAdapter()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.timeEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 46)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(760, 304)
			Me.schedulerControl1.Start = New System.DateTime(2008, 11, 18, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.ResourcesPerPage = 2
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.MonthView.ResourcesPerPage = 2
			Me.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
			Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
			Me.schedulerStorage1.Resources.DataSource = Me.carsBindingSource
			Me.schedulerStorage1.Resources.Mappings.Caption = "Model"
			Me.schedulerStorage1.Resources.Mappings.Id = "ID"
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsDeleted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl4)
			Me.panelControl1.Controls.Add(Me.labelControl3)
			Me.panelControl1.Controls.Add(Me.timeEdit2)
			Me.panelControl1.Controls.Add(Me.timeEdit1)
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.btnPrint)
			Me.panelControl1.Controls.Add(Me.dateEdit2)
			Me.panelControl1.Controls.Add(Me.dateEdit1)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(760, 46)
			Me.panelControl1.TabIndex = 1
			' 
			' timeEdit2
			' 
			Me.timeEdit2.EditValue = New System.DateTime(2008, 11, 18, 0, 0, 0, 0)
			Me.timeEdit2.Location = New System.Drawing.Point(637, 9)
			Me.timeEdit2.Name = "timeEdit2"
			Me.timeEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeEdit2.Size = New System.Drawing.Size(100, 20)
			Me.timeEdit2.TabIndex = 6
			' 
			' timeEdit1
			' 
			Me.timeEdit1.EditValue = New System.DateTime(2008, 11, 18, 0, 0, 0, 0)
			Me.timeEdit1.Location = New System.Drawing.Point(508, 9)
			Me.timeEdit1.Name = "timeEdit1"
			Me.timeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.timeEdit1.Size = New System.Drawing.Size(100, 20)
			Me.timeEdit1.TabIndex = 5
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(275, 12)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(13, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "to "
			' 
			' btnPrint
			' 
			Me.btnPrint.Location = New System.Drawing.Point(5, 6)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New System.Drawing.Size(75, 23)
			Me.btnPrint.TabIndex = 3
			Me.btnPrint.Text = "Print"
'			Me.btnPrint.Click += New System.EventHandler(Me.btnPrint_Click);
			' 
			' dateEdit2
			' 
			Me.dateEdit2.EditValue = Nothing
			Me.dateEdit2.Location = New System.Drawing.Point(294, 9)
			Me.dateEdit2.Name = "dateEdit2"
			Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit2.Size = New System.Drawing.Size(100, 20)
			Me.dateEdit2.TabIndex = 2
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(169, 9)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(100, 20)
			Me.dateEdit1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(86, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(77, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Print dates from"
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(413, 12)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(89, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Print interval from "
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(616, 12)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(13, 13)
			Me.labelControl4.TabIndex = 8
			Me.labelControl4.Text = "to "
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(760, 350)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.timeEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private dateEdit2 As DevExpress.XtraEditors.DateEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private carsDBDataSet As CarsDBDataSet
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As PrintAppointmentsInInterval.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As PrintAppointmentsInInterval.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private timeEdit2 As DevExpress.XtraEditors.TimeEdit
		Private timeEdit1 As DevExpress.XtraEditors.TimeEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

