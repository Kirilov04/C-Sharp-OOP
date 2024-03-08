namespace BorderControl.Models
{
    public class BorderControl
    {
        private List<BaseEntity> entities;
        private List<BaseEntity> detainedEntities;

        public List<BaseEntity> EntToBeChecked 
        {
            get => entities; 
        }

        public BorderControl()
        {
            entities = new ();
            detainedEntities = new ();
        }
        public void AddEntityForBCheck(BaseEntity entity)
        { 
         entities.Add (entity);
        }
    }
}
