namespace Entities
{
    public interface IEntityValidation
    {
        bool Validate();
        string ValidateWithMessage();
    }
}
