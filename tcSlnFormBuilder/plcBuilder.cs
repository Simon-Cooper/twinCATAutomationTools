﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using TCatSysManagerLib;
using System.Windows.Forms;

namespace tcSlnFormBuilder
{
    class PlcBuilder
    {
        private Solution solution;
        private String plcName;

        public PlcBuilder(Solution solution, String plcName)
        {
            this.solution = solution;
            this.plcName = plcName;
        }
        //public Boolean buildSolution()
        //public Boolean cleanSolution()
        public Project findPlcProject()
        {
            //Method to search through all projects in solution and find a valid PLC
            foreach (Project project in solution.Projects)
            {
                try
                {
                    ITcSysManager13 twinCatProject = (ITcSysManager13)project.Object;
                    ITcSmTreeItem plcProjectRootItem = twinCatProject.LookupTreeItem("TIPC^" + plcName);
                    ITcPlcProject iecProjectRoot = (ITcPlcProject)plcProjectRootItem;
                    iecProjectRoot.BootProjectAutostart = true;
                    iecProjectRoot.GenerateBootProject(true);
                    return project;
                }
                catch
                {
                    MessageBox.Show(project.Name + " has no PLC project of that name");
                }
            }
            return null;
        }
    }
}
