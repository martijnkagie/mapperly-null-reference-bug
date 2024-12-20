using Riok.Mapperly.Abstractions;

namespace MapperlyNullReferenceBug;

[Mapper(AllowNullPropertyAssignment = false)] //Bug is only present when "AllowNullPropertyAssignment = false"
internal static partial class Mapper
{
    [MapProperty([nameof(Foo.Property1)], [nameof(FooDto.BarDto), nameof(BarDto.PropertyA)])]
    [MapProperty([nameof(Foo.Property2)], [nameof(FooDto.BarDto), nameof(BarDto.PropertyB)])]
    public static partial FooDto ToDto(this Foo foo);

    private static double MapToDouble(int? value) => (double)(value ?? 0);
}
