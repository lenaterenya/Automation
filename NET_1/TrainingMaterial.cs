namespace NET_1
{
    public abstract class TrainingMaterial : MainEntity, ICloneable
    {
        public virtual object Clone()
        {
            return this;
        }
    }
}