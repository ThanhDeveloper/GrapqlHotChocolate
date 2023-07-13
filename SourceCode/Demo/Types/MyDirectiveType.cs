namespace Demo.Types
{
    public class MyDirective
    {
        public string Name { get; set; }
    }
    public class MyDirectiveType : DirectiveType
    {
        protected override void Configure(IDirectiveTypeDescriptor descriptor)
        {
            descriptor.Name("my");
            descriptor.Location(DirectiveLocation.Field);
        }
    }
}
