﻿using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;
using Sample.UI;


namespace MyRhinoPlugin1
{
    public class MyRhinoCommand1 : Command
    {
        public MyRhinoCommand1()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static MyRhinoCommand1 Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "MyRhinoCommand1";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {

            var myMainWindow = new MainView();
            myMainWindow.ShowDialog();
            myMainWindow.Topmost = true;
            return Result.Success;

        }
    }
}
