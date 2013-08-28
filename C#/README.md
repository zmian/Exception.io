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

## Contributors
- [Zeeshan Mian](http://zmian.me)

## License

(The MIT License)

Copyright (c) 2013 Zeeshan Mian

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
