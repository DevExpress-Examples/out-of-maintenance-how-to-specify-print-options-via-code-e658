Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Printing
Imports DevExpress.XtraPrinting

Namespace PrintAppointmentsInInterval
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			dateEdit1.DateTime = DateTime.Now.Date
			timeEdit1.Time = dateEdit1.DateTime + schedulerControl1.DayView.WorkTime.Start
			dateEdit2.DateTime = DateTime.Now.Date
			timeEdit2.Time = dateEdit2.DateTime + schedulerControl1.DayView.WorkTime.End

		End Sub

		Private Sub GenerateAppointments()
			For i As Integer = 0 To 1
				Dim apt As Appointment = schedulerStorage1.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal)
				apt.Start = DateTime.Now.AddHours(i+1)
				apt.End = apt.Start.AddHours(2)
				apt.Subject = "Test Appointment " & i
				apt.ResourceId = schedulerStorage1.Resources(i).Id
				schedulerStorage1.Appointments.Add(apt)
			Next i

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)
			GenerateAppointments()


		End Sub


		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted
			carSchedulingTableAdapter.Update(carsDBDataSet)
			carsDBDataSet.AcceptChanges()
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click

			Dim pcl As New PrintableComponentLink(New PrintingSystem())
			pcl.Component = Me.schedulerControl1
			' Set page margins.
			pcl.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)


			Dim pStyle As DailyPrintStyle = TryCast(Me.schedulerControl1.ActivePrintStyle, DailyPrintStyle)

			' Set fonts for appointments and column headings.
			pStyle.AppointmentFont = New Font("Arial", 8, FontStyle.Regular)
			pStyle.HeadingsFont = New Font("Arial", 10, FontStyle.Regular)

			' Specify whether the Calendar header should be printed.
			pStyle.CalendarHeaderVisible = False

			' Specify the intervals to print.
			pStyle.PrintTime = New TimeOfDayInterval(timeEdit1.Time.TimeOfDay, timeEdit2.Time.TimeOfDay)
			pStyle.StartRangeDate = dateEdit1.DateTime.Date
			pStyle.EndRangeDate = dateEdit2.DateTime.Date

			' Specify resources to print.
			pStyle.ResourceOptions.CustomResourcesCollection.Add(schedulerStorage1.Resources(0))
			pStyle.ResourceOptions.PrintCustomCollection = True
			pStyle.PrintAllAppointments = False

			pcl.CreateDocument()
			pcl.ShowPreviewDialog()

		End Sub
	End Class
End Namespace