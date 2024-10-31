using HotChocolate.Types;

namespace BookManagerGraphQL.Domain.Entities.Types;

public class ReviewType : ObjectType<Reviews>
{
    // protected override void Configure(IObjectTypeDescriptor<Reviews> descriptor)
    // {
    //     descriptor.Field(r => r.Id).Type<NonNullType<IdType>>();
    //     descriptor.Field(r => r.BookId).Type<NonNullType<IdType>>();
    //     descriptor.Field(r => r.Rating).Type<NonNullType<FloatType>>();
    //     descriptor.Field(r => r.Comment).Type<StringType>();
    // }
}