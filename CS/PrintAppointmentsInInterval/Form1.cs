using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Printing;
using DevExpress.XtraPrinting;

namespace PrintAppointmentsInInterval {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            dateEdit1.DateTime = DateTime.Now.Date;
            timeEdit1.Time = dateEdit1.DateTime + schedulerControl1.DayView.WorkTime.Start;
            dateEdit2.DateTime = DateTime.Now.Date;
            timeEdit2.Time = dateEdit2.DateTime + schedulerControl1.DayView.WorkTime.End;

        }

        private void GenerateAppointments() {
            for (int i = 0; i < 2; i++) {
                Appointment apt = schedulerStorage1.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);
                apt.Start = DateTime.Now.AddHours(i+1);
                apt.End = apt.Start.AddHours(2);
                apt.Subject = "Test Appointment " + i;
                apt.ResourceId = schedulerStorage1.Resources[i].Id;
                schedulerStorage1.Appointments.Add(apt);
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);
            GenerateAppointments();


        }


        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e) {
            carSchedulingTableAdapter.Update(carsDBDataSet);
            carsDBDataSet.AcceptChanges();
        }

        private void btnPrint_Click(object sender, EventArgs e) {

            PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
            pcl.Component = this.schedulerControl1;
            // Set page margins.
            pcl.Margins = new System.Drawing.Printing.Margins(30, 30, 30, 30);
         

            DailyPrintStyle pStyle = this.schedulerControl1.ActivePrintStyle as DailyPrintStyle;
            
            // Set fonts for appointments and column headings.
            pStyle.AppointmentFont = new Font("Arial", 8, FontStyle.Regular);
            pStyle.HeadingsFont = new Font("Arial", 10, FontStyle.Regular);

            // Specify whether the Calendar header should be printed.
            pStyle.CalendarHeaderVisible = false;
            
            // Specify the intervals to print.
            pStyle.PrintTime = new TimeOfDayInterval(timeEdit1.Time.TimeOfDay, timeEdit2.Time.TimeOfDay);
            pStyle.StartRangeDate = dateEdit1.DateTime.Date;
            pStyle.EndRangeDate = dateEdit2.DateTime.Date;

            // Specify resources to print.
            pStyle.ResourceOptions.CustomResourcesCollection.Add(schedulerStorage1.Resources[0]);
            pStyle.ResourceOptions.PrintCustomCollection = true;
            pStyle.PrintAllAppointments = false;

            pcl.CreateDocument();
            pcl.ShowPreviewDialog();

        }
    }
}