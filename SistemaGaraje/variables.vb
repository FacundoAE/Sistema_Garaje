Module variables
    'Bandera para indicar el tipo de acción que se ejecuta sobre el boton CONFIRMAR (ALTA - MODIFICACION - BAJA)
    Public flag_abm As Integer = 0 '1 ALTA - 2 MODIFICACION - 3 BAJA

    'Variable para traer la FK en la carga de registros
    Public wrfm As Integer = 0

    'Garaje seleccionado para trabajar
    Public grjSel As Integer = 0
    Public grjNom As String

    'Numero de ticket para salir
    Public nroTick As Integer

    'comparar
    Public grjSel2 As Integer = 0
    Public grjNom2 As String

    'Redondear cada 15 minutos el tiempo utilizado al calcular el total
    'Mostrar el garaje más utilizado ese mes o por fecha comparando diferentes garajes
    'Garaje 1 y garaje 2 a comprar seleccionarlos
    'Agregar a tickets el precio x hora del garaje

End Module
