﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace CodigoLegado.ServicioWeb
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="NuevoProyecto", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb.AgregarProyecto"),  _
     System.SerializableAttribute()>  _
    Partial Public Class NuevoProyecto
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FechaDeInicioField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NombreField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FechaDeInicio() As Date
            Get
                Return Me.FechaDeInicioField
            End Get
            Set
                If (Me.FechaDeInicioField.Equals(value) <> true) Then
                    Me.FechaDeInicioField = value
                    Me.RaisePropertyChanged("FechaDeInicio")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Nombre() As String
            Get
                Return Me.NombreField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NombreField, value) <> true) Then
                    Me.NombreField = value
                    Me.RaisePropertyChanged("Nombre")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ProyectoCreado", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb.AgregarProyecto"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ProyectoCreado
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FechaDeCreacionField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FechaDeInicioField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NombreField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FechaDeCreacion() As Date
            Get
                Return Me.FechaDeCreacionField
            End Get
            Set
                If (Me.FechaDeCreacionField.Equals(value) <> true) Then
                    Me.FechaDeCreacionField = value
                    Me.RaisePropertyChanged("FechaDeCreacion")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FechaDeInicio() As Date
            Get
                Return Me.FechaDeInicioField
            End Get
            Set
                If (Me.FechaDeInicioField.Equals(value) <> true) Then
                    Me.FechaDeInicioField = value
                    Me.RaisePropertyChanged("FechaDeInicio")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Nombre() As String
            Get
                Return Me.NombreField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NombreField, value) <> true) Then
                    Me.NombreField = value
                    Me.RaisePropertyChanged("Nombre")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ErrorDeValidacionFault", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ErrorDeValidacionFault
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FechaField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MensajeField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Fecha() As Date
            Get
                Return Me.FechaField
            End Get
            Set
                If (Me.FechaField.Equals(value) <> true) Then
                    Me.FechaField = value
                    Me.RaisePropertyChanged("Fecha")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Mensaje() As String
            Get
                Return Me.MensajeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.MensajeField, value) <> true) Then
                    Me.MensajeField = value
                    Me.RaisePropertyChanged("Mensaje")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ErrorInesperadoFault", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ErrorInesperadoFault
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FechaField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MensajeField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Fecha() As Date
            Get
                Return Me.FechaField
            End Get
            Set
                If (Me.FechaField.Equals(value) <> true) Then
                    Me.FechaField = value
                    Me.RaisePropertyChanged("Fecha")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Mensaje() As String
            Get
                Return Me.MensajeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.MensajeField, value) <> true) Then
                    Me.MensajeField = value
                    Me.RaisePropertyChanged("Mensaje")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="CodigoLegado.ServicioWeb.ServicioCrearProyecto")>  _
    Public Interface ServicioCrearProyecto
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyecto", ReplyAction:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyectoResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(CodigoLegado.ServicioWeb.ErrorDeValidacionFault), Action:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyectoErrorDeValidacionFaultF"& _ 
            "ault", Name:="ErrorDeValidacionFault", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb"),  _
         System.ServiceModel.FaultContractAttribute(GetType(CodigoLegado.ServicioWeb.ErrorInesperadoFault), Action:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyectoErrorInesperadoFaultFau"& _ 
            "lt", Name:="ErrorInesperadoFault", [Namespace]:="http://schemas.datacontract.org/2004/07/CodigoLegado.ServicioWeb")>  _
        Function AgregueUnProyecto(ByVal nuevoProyecto As CodigoLegado.ServicioWeb.NuevoProyecto) As CodigoLegado.ServicioWeb.ProyectoCreado
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyecto", ReplyAction:="http://tempuri.org/ServicioCrearProyecto/AgregueUnProyectoResponse")>  _
        Function AgregueUnProyectoAsync(ByVal nuevoProyecto As CodigoLegado.ServicioWeb.NuevoProyecto) As System.Threading.Tasks.Task(Of CodigoLegado.ServicioWeb.ProyectoCreado)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServicioCrearProyectoChannel
        Inherits CodigoLegado.ServicioWeb.ServicioCrearProyecto, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServicioCrearProyectoClient
        Inherits System.ServiceModel.ClientBase(Of CodigoLegado.ServicioWeb.ServicioCrearProyecto)
        Implements CodigoLegado.ServicioWeb.ServicioCrearProyecto
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function AgregueUnProyecto(ByVal nuevoProyecto As CodigoLegado.ServicioWeb.NuevoProyecto) As CodigoLegado.ServicioWeb.ProyectoCreado Implements CodigoLegado.ServicioWeb.ServicioCrearProyecto.AgregueUnProyecto
            Return MyBase.Channel.AgregueUnProyecto(nuevoProyecto)
        End Function
        
        Public Function AgregueUnProyectoAsync(ByVal nuevoProyecto As CodigoLegado.ServicioWeb.NuevoProyecto) As System.Threading.Tasks.Task(Of CodigoLegado.ServicioWeb.ProyectoCreado) Implements CodigoLegado.ServicioWeb.ServicioCrearProyecto.AgregueUnProyectoAsync
            Return MyBase.Channel.AgregueUnProyectoAsync(nuevoProyecto)
        End Function
    End Class
End Namespace
