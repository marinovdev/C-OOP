using System;
using System.Collections.Generic;
using System.Text;

namespace ex01.Layouts
{
    class JsonLayout : ILayout
    {
        public string Format => @"{{
    ""log"": {{
    ""date"": {0},
    ""level"": {1},
    ""message"": {2}
  }}
}}";
    }
}
