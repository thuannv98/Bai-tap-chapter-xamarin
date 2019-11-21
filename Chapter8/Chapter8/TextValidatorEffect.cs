using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter8
{
    public class TextValidatorEffect : RoutingEffect
    {
        public int MaxLength { get; set; } = 5;
        public TextValidatorEffect() : base("EffectExample.TextValidatorEffect") { }
    }
}
