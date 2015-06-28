/*
 * Created by SharpDevelop.
 * User: Radimir
 * Date: 12.04.2015
 * Time: 21:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;

namespace Facebook_Messenger
{
	public partial class MainForm : Form
	{
		[DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
  		internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

	    [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
	    internal static extern IntPtr GetCurrentProcess();
		public MainForm()
		{
			InitializeComponent();
			this.mainBrowser.Navigate( new Uri( "http://www.messenger.com" ) );
			System.Timers.Timer cleanupTimer = new System.Timers.Timer();
		    cleanupTimer.Elapsed += new ElapsedEventHandler(CleanUp);
		    cleanupTimer.Interval = 1000;
		    cleanupTimer.Enabled = true;
		}
		
		private void WebBrowser1DocumentCompleted( object source, WebBrowserDocumentCompletedEventArgs e ) {
			
		}
		
		// Fix for WebBrowser component memory leak
		// Source: http://stackoverflow.com/a/6258063
		private void CleanUp( object source, ElapsedEventArgs e ) {
			IntPtr pHandle = GetCurrentProcess();
      		SetProcessWorkingSetSize(pHandle, -1, -1);
		}
	}
}