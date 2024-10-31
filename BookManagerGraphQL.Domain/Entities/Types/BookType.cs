using HotChocolate.Types;

namespace BookManagerGraphQL.Domain.Entities.Types;

public class BookType : ObjectType<Book>
{
    // protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    // {
    //     descriptor.Field(b => b.Id).Type<NonNullType<IdType>>();
    //     descriptor.Field(b => b.Title).Type<NonNullType<StringType>>();
    //     descriptor.Field(b => b.Author).Type<NonNullType<StringType>>();
    //     descriptor.Field(b => b.Genre).Type<NonNullType<StringType>>();
    //     descriptor.Field(b => b.CreatedAt).Type<NonNullType<DateTimeType>>();
    //     descriptor.Field(b => b.Status).Type<NonNullType<EnumType<Status>>>();
    // }
}