using System;
using System.Collections.Generic;

namespace TrainsClassLibraryFile.Models
{
    public partial class DaysOnWhichEveryTrainRun
    {
        public int Id { get; set; }
        public string? TrainRunDays { get; set; }
        public int? TrainNo { get; set; }

        public virtual Train? TrainNoNavigation { get; set; }
    }
}
