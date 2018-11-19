using System.Collections.ObjectModel;

namespace FSBeheer.Model
{
    public partial class Questionnaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questionnaire()
        {
            Questions = new ObservableCollection<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public int Version { get; set; }
        public string Comments { get; set; }
        public int? InspectionId { get; set; }
        public virtual Inspection Inspection { get; set; }
        public virtual ObservableCollection<Question> Questions { get; set; }
    }
}
