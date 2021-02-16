namespace Template.Domain.Entities
{
    public class ModuleProfile
    {
	public long ModuleId { get; set; }
	public long ProfileId { get; set; }

	public virtual Module Module { get; set; }
	public virtual Profile Profile { get; set; }
    }
}
