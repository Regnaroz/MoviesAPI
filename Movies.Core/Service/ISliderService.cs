using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ISliderService
    {
        public List<Slider> GetSlider();
        public bool InsertSlider(Slider Slider);
        public bool UpdateSlider(Slider Slider);
        public bool DeleteSlider(int id);
    }
}
