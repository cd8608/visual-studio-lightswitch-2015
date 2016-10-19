//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Resources;

using Microsoft.LightSwitch.Presentation;

namespace ApressExtensionCS.Presentation.Controls
{
    public partial class DurationEditor : UserControl, IContentVisual
    {
        public DurationEditor()
        {
            InitializeComponent();
        }

        //Listing 19-3. Adding Support for the FindControl Method   

        //1. Implement the Control property 
        object IContentVisual.Control
        {
            get { return this.DurationControl; }
        }

        //2. Implement the Show method 
        void IContentVisual.Show()
        {
            throw new NotImplementedException(
                "Show method not implemented");
        }


    }

    [Export(typeof(IControlFactory))]
    [ControlFactory("ApressExtensionCS:DurationEditor")]
    internal class DurationEditorFactory : IControlFactory
    {


        //Listing 19-6. Returning a Read-Only Display-Mode Template  

        #region IControlFactory Members


        private const string DisplayModeControlTemplate =                          
   "<DataTemplate" +
   @" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""" +
   @" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""" +
   @" xmlns:ctl=""clr-namespace:ApressExtensionCS.Presentation.Controls;
       assembly=ApressExtensionCS.Client"">" +
   @"<ctl:DurationViewer/>" +
   @"</DataTemplate>";


        public DataTemplate DataTemplate
        {
            get
            {
                if (null == this.dataTemplate)
                {
                    this.dataTemplate = XamlReader.Load(DurationEditorFactory.ControlTemplate) as DataTemplate;
                }
                return this.dataTemplate;
            }
        }

        private DataTemplate cachedDisplayDataTemplate;

        public DataTemplate GetDisplayModeDataTemplate(IContentItem contentItem)
        {
            // provide the display mode template
            if (null == this.cachedDisplayDataTemplate)
            {
                this.cachedDisplayDataTemplate =
                  XamlReader.Load(
                    DurationEditorFactory.DisplayModeControlTemplate) as DataTemplate;
            }
            return this.cachedDisplayDataTemplate;
        }


        #endregion

        #region Private Fields

        private DataTemplate dataTemplate;

        #endregion

        #region Constants

        private const string ControlTemplate =
            "<DataTemplate" +
            " xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"" +
            " xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"" +
            " xmlns:ctl=\"clr-namespace:ApressExtensionCS.Presentation.Controls;assembly=ApressExtensionCS.Client\">" +
            "<ctl:DurationEditor/>" +
            "</DataTemplate>";

        #endregion
    }
}
