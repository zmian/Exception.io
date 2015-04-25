Exception.io: C#
================
A collection of custom exception classes written in C#.

## Inheritance Hierarchy

    System.Object
    └── System.Exception
        └── System.SystemException
            └── Exceptionio.NotFoundException

## Classes

<table>
  <thead>
    <tr><th>Class Name</th><th>Description</th><th>Default Message</th></tr>
  </thead>
  <tbody>
    <tr><td>NotFoundException</td><td>The exception that is thrown when a requested method or operation not found.</td><td>The method or operation not found.</td></tr>
  </tbody>
</table>

## Usage

Initiate any one of the exception classes:

    if (item == null)
    {
        throw new NotFoundException("Item not found.");
    }

An example of handling specific exception:

    /// <summary>
    /// A filter that converts NotFoundException exceptions into HTTP status code 404, Not Found.
    /// </summary>
    /// <example>config.Filters.Add(new Xcore.Filters.NotFoundExceptionFilterAttribute());</example>
    /// <link>http://blogs.msdn.com/b/youssefm/archive/2012/06/28/error-handling-in-asp-net-webapi.aspx</link>
    public class NotFoundExceptionFilterAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is NotFoundException)
            {
                context.Response = context.Request.CreateResponse(HttpStatusCode.NotFound, new ResponseModel(new MetaModel { Message = string.Format(context.Exception.Message), Code = 404, Success = false }));
            }
        }
    }

## Supported Platforms

- [.NET Framework](http://msdn.microsoft.com/en-us/library/w0x726c2.aspx)

## Creator

- [Zeeshan Mian](https://github.com/zmian) ([@zmian](https://twitter.com/zmian))

## License

Exception.io is released under the MIT license. See LICENSE for details.
