﻿namespace InventoryManagementSystem
{
    partial class ProductPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2 = new InventoryManagementSystem._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbProductTableAdapter = new InventoryManagementSystem._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2TableAdapters.tbProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductBindingSource
            // 
            this.tbProductBindingSource.DataMember = "tbProduct";
            this.tbProductBindingSource.DataSource = this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2;
            // 
            // _D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2
            // 
            this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2.DataSetName = "_D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2";
            this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProductDataSet";
            reportDataSource1.Value = this.tbProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryManagementSystem.ProductPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1089, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbProductTableAdapter
            // 
            this.tbProductTableAdapter.ClearBeforeFill = true;
            // 
            // ProductPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductPrint";
            this.Text = "ProductPrint";
            this.Load += new System.EventHandler(this.ProductPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2 _D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2;
        private System.Windows.Forms.BindingSource tbProductBindingSource;
        private _D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2TableAdapters.tbProductTableAdapter tbProductTableAdapter;
    }
}