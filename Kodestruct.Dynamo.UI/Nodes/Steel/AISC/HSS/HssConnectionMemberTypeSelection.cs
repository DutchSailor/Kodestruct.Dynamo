#region Copyright
   /*Copyright (C) 2015 Konstantin Udilovich

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   */
#endregion
 
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Wpf;
using ProtoCore.AST.AssociativeAST;
using Kodestruct.Common.CalculationLogger;
using Kodestruct.Dynamo.Common;
using Dynamo.Nodes;
using System.Xml;
using Dynamo.Graph;
using Dynamo.Graph.Nodes;


namespace Kodestruct.Steel.AISC.HSS
{

    /// <summary>
    ///HSS truss connection member type selection  
    /// </summary>

    [NodeName("HSS connection member type selection")]
    [NodeCategory("Kodestruct.Steel.AISC.HSS")]
    [NodeDescription("HSS connection member type selection")]
    [IsDesignScriptCompatible]
    public class HssConnectionMemberTypeSelection : UiNodeBase
    {

        public HssConnectionMemberTypeSelection()
        {
            
            //OutPortData.Add(new PortData("ReportEntry", "Calculation log entries (for reporting)"));
            OutPortData.Add(new PortData("HssConnectionMemberType", "Specifies if the connection members are circular HSS (CHS) or rectangular HSS (RHS)"));
            RegisterAllPorts();
            SetDefaultParameters();
            //PropertyChanged += NodePropertyChanged;
        }

        private void SetDefaultParameters()
        {
            //ReportEntry="";
            HssConnectionMemberType = "Rhs";
        }


        /// <summary>
        ///     Gets the type of this class, to be used in base class for reflection
        /// </summary>
        protected override Type GetModelType()
        {
            return GetType();
        }

        #region Properties

        #region InputProperties



	    #endregion

        #region OutputProperties

		#region HssTrussConnectionMemberTypeProperty
		
		/// <summary>
		/// HssTrussConnectionMemberType property
		/// </summary>
		/// <value>Specifies if the connection members are circular HSS (CHS) or rectangular HSS</value>
		public string _HssConnectionMemberType;
		
		public string HssConnectionMemberType
		{
		    get { return _HssConnectionMemberType; }
		    set
		    {
		        _HssConnectionMemberType = value;
		        RaisePropertyChanged("HssConnectionMemberType");
		        OnNodeModified();
		    }
		}
		#endregion



        #region ReportEntryProperty

        /// <summary>
        /// log property
        /// </summary>
        /// <value>Calculation entries that can be converted into a report.</value>

        public string reportEntry;

        public string ReportEntry
        {
            get { return reportEntry; }
            set
            {
                reportEntry = value;
                RaisePropertyChanged("ReportEntry");
                OnNodeModified();
            }
        }




        #endregion

        #endregion
        #endregion

        #region Serialization

        /// <summary>
        ///Saves property values to be retained when opening the node     
        /// </summary>
        protected override void SerializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.SerializeCore(nodeElement, context);
            nodeElement.SetAttribute("HssConnectionMemberType", HssConnectionMemberType);
        }

        /// <summary>
        ///Retrieved property values when opening the node     
        /// </summary>
        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);
            var attrib = nodeElement.Attributes["HssConnectionMemberType"];
            if (attrib == null)
                return;
           
            HssConnectionMemberType = attrib.Value;
            //SetComponentDescription();

        }



        #endregion





        /// <summary>
        ///Customization of WPF view in Dynamo UI      
        /// </summary>
        public class HssTrussConnectionMemberTypeSelectionViewCustomization : UiNodeBaseViewCustomization,
            INodeViewCustomization<HssConnectionMemberTypeSelection>
        {
            public void CustomizeView(HssConnectionMemberTypeSelection model, NodeView nodeView)
            {
                base.CustomizeView(model, nodeView);

                HssConnectionMemberTypeSelectionView control = new HssConnectionMemberTypeSelectionView();
                control.DataContext = model;
                
                
                nodeView.inputGrid.Children.Add(control);
                base.CustomizeView(model, nodeView);
            }

        }
    }
}
