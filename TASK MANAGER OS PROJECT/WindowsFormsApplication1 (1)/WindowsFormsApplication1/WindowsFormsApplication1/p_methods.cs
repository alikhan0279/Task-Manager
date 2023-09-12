using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApplication1
{
    class p_methods
    {
        public int tot;
        public static decimal memory, cpu;


        
        Process[] proc;
        public string[] pro;
        string[] ID;
        string[] MEMORY;
        string[] VM;
        string[] UPT; //Base Priority
        string[] STA; //Status
        string[] CPU_USAGE;
        string[] process_Details;
        public void GetProcess(ListBox l1)
        {// home page pe process get kr rahai hy is pe list box mai
            proc = Process.GetProcesses();
            
            l1.Items.Clear();
            foreach (Process P in proc) // process check kry ga 
            {
                tot++;
                l1.Items.Add(P.ProcessName);
            }
            pro = new string[tot];
            int i = 0;
            foreach (Process P in proc)
            {
                pro[i] = P.ProcessName;
                i++;
                
            }   
      
                      
        }

        public void kill(ListBox l1)
        {
            proc[l1.SelectedIndex].Kill();
        }

     //Detail form
        public void Detailss(ListView LV1)
        {// is line se hum detail ke leye process get kr rahai hy 
            proc = Process.GetProcesses();
            
            foreach (Process P in proc)
            {

                tot++;
            }
            // detaial ke form mai show kr rahai hy chezy
            pro = new string[tot];
            ID = new string[tot];
            MEMORY = new string[tot];
           
            VM = new string[tot];
            UPT = new string[tot];
            STA = new string[tot];
            CPU_USAGE = new string[tot];
            process_Details = new string[tot];
          

            int i = 0;
            foreach (Process P in proc)
            {
                try
                { // process name show kr raha hy detail ke form mai
                    pro[i] = P.ProcessName;
                    i++;
                }


                catch (Exception)
                {
                    
                    throw;
                }
              
            }

            //Process ID
            for (int k = 0; k < tot; k++)
            {
                PerformanceCounter PC = new PerformanceCounter("Process", "ID Process", pro[k]);
                double pct = PC.RawValue;
                ID[k] = pct.ToString() + " ";

            }
            // memory
            for (int k = 0; k < tot; k++)
            {
                PerformanceCounter PC = new PerformanceCounter("Process", "Working Set - Private", pro[k]);
                decimal pct = (PC.RawValue) / 1024;
                memory += pct;
                MEMORY[k] = pct.ToString() + " ";
            }
            // cpu usage
            for (int k = 0; k < tot; k++)
            {
                PerformanceCounter PC = new PerformanceCounter("Process", "% Processor Time", pro[k]);
                decimal pct = (PC.RawValue) / 1024;
                cpu += pct;
                CPU_USAGE[k] = pct.ToString() + " ";
            }

            

            //COMMENTTT VIRTUAL MEMORY

            for (int k = 0; k < tot; k++)
            {
                int A = Convert.ToInt32(ID[k]);
                Process Pr = Process.GetProcessById(A);
            
                VM[k] = Convert.ToString(Pr.VirtualMemorySize64);
            }
            //This Code is For Base Priority

            for (int k = 0; k < tot; k++)
            {
                int A = Convert.ToInt32(ID[k]);
                Process Pr = Process.GetProcessById(A);
        
                UPT[k] = Convert.ToString(Pr.BasePriority); //Gets the base priority of the Associated Process
            }
         //This Code is For Showing the Status
            for (int k = 0; k < tot; k++)
            {
                int A = Convert.ToInt32(ID[k]);
                Process Pr = Process.GetProcessById(A);
     
                STA[k] = Convert.ToString(Pr.Responding); //Responding is a BOol Value 
            }

           
        
            //This Code is for All The Lists Show in the Form Details.Cs
            for (int k = 0; k < tot; k++)
            {
                ListViewItem lvt = new ListViewItem(pro[k]);                
                lvt.SubItems.Add(ID[k]);
                lvt.SubItems.Add(MEMORY[k]);
                lvt.SubItems.Add(CPU_USAGE[k]);
               
                lvt.SubItems.Add(VM[k]);
                lvt.SubItems.Add(UPT[k]);
                lvt.SubItems.Add(STA[k]); //Status
                
                LV1.Items.Add(lvt);

            }

          


        }

      
    }
}
