// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Greet
  {
    static readonly string __ServiceName = "Greet";

    static readonly grpc::Marshaller<global::GrpcServer.ClientInputRequest> __Marshaller_ClientInputRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.ClientInputRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.EmptyMessage> __Marshaller_EmptyMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.EmptyMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.ClientInputRequest, global::GrpcServer.EmptyMessage> __Method_PrintClientInput = new grpc::Method<global::GrpcServer.ClientInputRequest, global::GrpcServer.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PrintClientInput",
        __Marshaller_ClientInputRequest,
        __Marshaller_EmptyMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greet</summary>
    [grpc::BindServiceMethod(typeof(Greet), "BindService")]
    public abstract partial class GreetBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.EmptyMessage> PrintClientInput(global::GrpcServer.ClientInputRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreetBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PrintClientInput, serviceImpl.PrintClientInput).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreetBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PrintClientInput, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.ClientInputRequest, global::GrpcServer.EmptyMessage>(serviceImpl.PrintClientInput));
    }

  }
}
#endregion
