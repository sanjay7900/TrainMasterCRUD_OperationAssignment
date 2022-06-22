using System;
using System.Collections.Generic;

namespace TrainsClassLibraryFile.Models
{
    public partial class Train
    {
        public Train()
        {
            DaysOnWhichEveryTrainRuns = new HashSet<DaysOnWhichEveryTrainRun>();
        }

        public int Id { get; set; }
        public int? TrainNo { get; set; }
        public string? TrainName { get; set; }
        public string? FromStation { get; set; }
        public string? ToStation { get; set; }
        public TimeSpan? JourneyStartTime { get; set; }
        public TimeSpan? JourneyEndTime { get; set; }

        public virtual ICollection<DaysOnWhichEveryTrainRun> DaysOnWhichEveryTrainRuns { get; set; }
    }
}
