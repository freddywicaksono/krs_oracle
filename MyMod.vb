Imports System.Data.OracleClient
Module MyMod
    Public mycommand As New System.Data.OracleClient.OracleCommand
    Public myadapter As New System.Data.OracleClient.OracleDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.OracleClient.OracleDataReader
    Public SQL As String
    Public conn As New System.Data.OracleClient.OracleConnection
    Public cn As New Connection


    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    'Tabel Prodi
    '-------------------------------
    Public prodi_baru As Boolean
    Public oprodi As New Prodi
    '--------------------------------

    'Tabel Dosen
    '-------------------------------
    Public dosen_baru As Boolean
    Public odosen As New Dosen
    '--------------------------------

    'Tabel Mahasiswa
    '-------------------------------
    Public mahasiswa_baru As Boolean
    Public omahasiswa As New Mahasiswa
    '--------------------------------

    'Tabel Matakuliah
    '-------------------------------
    Public matakuliah_baru As Boolean
    Public omatakuliah As New Matakuliah
    '--------------------------------

    'Tabel Krs
    '-------------------------------
    Public krs_baru As Boolean
    Public krsdetail_baru As Boolean
    Public oKrs As New Krs
    '--------------------------------

    Public nobukti As Double
    Public R As Random = New Random

    Public Sub DBConnect()
        cn.DataSource = "xe"
        cn.UserID = "freddy"
        cn.Password = "123"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub

    Public Function getNomorBukti()
        Dim res As Double
        res = R.Next(1000000, 9999999)
        Return res
    End Function
End Module
