using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class SliderService: ISliderService
    {
        private readonly ISliderRepository SliderRepository;
        public SliderService(ISliderRepository SliderRepository)
        {
            this.SliderRepository = SliderRepository;
        }

        public bool DeleteSlider(int id)
        {
            return SliderRepository.DeleteSlider(id);
        }

        public List<Slider> GetSlider()
        {
            return SliderRepository.GetSlider();
        }

        public bool InsertSlider(Slider Slider)
        {
            return SliderRepository.InsertSlider(Slider);
        }

        public bool UpdateSlider(Slider Slider)
        {
            return SliderRepository.UpdateSlider(Slider);
        }
    }
}
