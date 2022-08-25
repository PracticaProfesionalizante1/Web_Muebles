
Imports Datos
Imports System.Data
Public Class Roles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar_grilla()
        ' Limpiar()
    End Sub
    Dim oDs As New Data.DataSet
    Dim ORoles As New Roles
    Public Sub cargar_grilla()
        oDs = New Data.DataSet
        ORoles = New Roles
        oDs = ORoles.Buscar_Todos()
        grlGrilla.DataSource = oDs.Tables(0)
        grlGrilla.DataBind()
    End Sub
    Public Sub Limpiar()

        txt_ID_Rol.Text = ""
        txt_NombreRol.Text = ""

    End Sub
    Protected Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        If txt_NombreRol.Text <> "" Then
            ORoles.Agregar(txt_NombreRol.Text)
            MsgBox("Rol agregado", vbInformation, "Roles")
            cargar_grilla()
            Limpiar()
        End If

    End Sub
    Protected Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If txt_ID_Rol.Text <> Nothing Then
            Dim oDs As New Data.DataSet
            Dim ORoles As New Roles
            oDs = New Data.DataSet
            ORoles = New Roles
            oDs = ORoles.Buscar_ID(txt_ID_Rol.Text)
            If oDs.Tables(0).Rows.Count > 0 Then
                txt_NombreRol.Text = (oDs.Tables(0).Rows(0).Item("Nombre"))

            Else
                MsgBox("ID Incorrecto", vbInformation, "Roles")
            End If
        End If
    End Sub

    Protected Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If txt_ID_Rol.Text <> Nothing Then
            Dim oDs As New Data.DataSet
            Dim ORoles As New Roles
            oDs = New Data.DataSet
            ORoles = New Roles
            oDs = ORoles.Buscar_ID(txt_ID_Rol.Text)
            If oDs.Tables(0).Rows.Count > 0 Then
                ORoles.Modificar(txt_ID_Rol.Text, txt_NombreRol.Text)
                MsgBox("Rol modificado", vbInformation, "Roles")
                cargar_grilla()
                'limpiar
            Else
                MsgBox("ID Incorrecto", vbInformation, "Roles")
            End If
        End If



    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txt_ID_Rol.Text <> Nothing Then
            Dim oDs As New Data.DataSet
            Dim ORoles As New Roles
            oDs = New Data.DataSet
            ORoles = New Roles
            oDs = ORoles.Buscar_ID(txt_ID_Rol.Text)
            If oDs.Tables(0).Rows.Count > 0 Then
                ORoles.Eliminar(txt_ID_Rol.Text)
                MsgBox("Alumno eliminado", vbInformation, "Roles")
                cargar_grilla()
                'limpiar
            Else
                MsgBox("ID Incorrecto", vbInformation, "Roles")
            End If
        End If
    End Sub
End Class