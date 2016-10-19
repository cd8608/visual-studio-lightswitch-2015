﻿// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".

using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Issue
    {

        //Listing 2-4. Creating a computed property that returns an image
        partial void Icon_Compute(ref byte[] result)
        {
            if (TargetEndDateTime < DateTime.Now)
            {
                string base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAYAAAAfSC3RAAAABGdBTUEAANbY1E9YMgAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAGWSURBVHjaYvz//z8DDKzu5mEGUmlA7AfEolDh+0C8OLT0yyYGJMAI0wjUlMDIyDBfSf83g5TKXwZ2Loj41w9MDA+vsTA8u8O8HsidDjRgN1gCpHFVF3fOttmc/98+YwJx/585w/C/o4Ph/927YGkwfnKL+f+GSVz/gWqdwJYBGUJrern/f3zDBFfk4sIAsg6sGSYGwo9vsIA0rgZxmIAKMtVNfzPwCf9jIARk1P+AvBEC9JYfSGMISIBYIKMGVhsC0qjIzf8fRdLYGEIrKWFq5OIDq5VjwmaqoCAqjRINjGCKGaTxxY+vjAz4DEAGULUvWIDE1uf3mNV5hRCBk5aG6mRkAFQLoraCbJx+7Rgrw7dPCFtXr2Zg2LOHgeHsWVRNrx8zMzy4wnIQmAgWMAGJO79/Mlae2MzB8OsHRDNIEwzDwJf3TAyntrGDmNPRk1wLB/f/ajWT3wxMXP8Y7j35x+Bgx8Dw7gUTw5snzAx3zrMw/PnFWAy0qA9FI1SzIihBALEZyItA/B2ITwHxEWg6/QhTCxBgAB4kvHiHyye8AAAAAElFTkSuQmCC";
                result = Convert.FromBase64String(base64EncodedImage);
            }
            else
            {
                result = null;
            }
        }

    }
}