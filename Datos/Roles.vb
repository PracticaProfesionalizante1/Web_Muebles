Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Public Class Roles
    Dim ORoles As Database

    Public Sub New()
        ORoles = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function Agregar(ByVal Nombre As String) As Double
        ORoles.ExecuteScalar("RolesAgregar", Nombre)
        Return 0
    End Function
    Public Function Buscar_Todos() As DataSet
        Return ORoles.ExecuteDataSet("BuscarTodosRoles")
    End Function
    Public Function Buscar_ID(ByVal ID As Integer) As DataSet
        Return ORoles.ExecuteDataSet("BuscarxID", ID)
    End Function
    Public Function Modificar(ByVal ID As Integer, ByVal Nombre As String) As Double
        ORoles.ExecuteScalar("RolesModificar", ID, Nombre)
        Return 0
    End Function
    Public Function Eliminar(ByVal ID As Integer) As Double
        ORoles.ExecuteScalar("RolesEliminar", ID)
        Return 0
    End Function

End Class
