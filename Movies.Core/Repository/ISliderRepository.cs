using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface ISliderRepository
    {
        public List<Slider> GetSlider();
        public bool InsertSlider(Slider Slider);
        public bool UpdateSlider(Slider Slider);
        public bool DeleteSlider(int id);
    }
}
