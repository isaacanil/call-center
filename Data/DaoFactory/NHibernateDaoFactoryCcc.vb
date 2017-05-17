Imports Core.DataInterfaces
Imports Core.Domain.CccEntidades
Imports Core.Domain.MsjErrorEntidades
Imports NHibernate
Imports NHibernate.Expression
Imports Core.Domain.Logs

Namespace Data

    Public Class NHibernateDaoFactoryCcc
        Implements IDaoFactoryCcc


#Region "Consulta_Avanzada"

        Public Function GetAgeDao() As IAgeDao Implements IDaoFactoryCcc.GetAgeDao
            Return New CccAgeDao
        End Function
        Public Class CccAgeDao
            Inherits GenericNHibernateDao(Of CccAge, String)
            Implements IAgeDao
            Public Function GetByParam(_param1 As String, _param2 As String) As List(Of CccAge) Implements IAgeDao.GetByParam
                Dim Agelist As IList
                Try
                    Agelist = NHibernateSession.GetNamedQuery("SelectAge").SetString("param1", _param1).SetString("param2", _param2).List

                    If Agelist.Count > 0 Then
                        Return ConvertToGenericList(Agelist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetDatoAgeDao() As IDatoAgeDao Implements IDaoFactoryCcc.GetDatoAgeDao
            Return New CccDatoAgeDao
        End Function
        Public Class CccDatoAgeDao
            Inherits GenericNHibernateDao(Of CccDatoAge, String)
            Implements IDatoAgeDao
            Public Function GetByAge(_age As String) As List(Of CccDatoAge) Implements IDatoAgeDao.GetByAge
                Dim Agelist As IList
                Try
                    Agelist = NHibernateSession.GetNamedQuery("SelectDatoAge").SetString("age", _age).List

                    If Agelist.Count > 0 Then
                        Return ConvertToGenericList(Agelist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetDatoGesAge() As IDatoGesAge Implements IDaoFactoryCcc.GetDatoGesAge

            Return New CccDatGesAges
        End Function
        Public Class CccDatGesAges
            Inherits GenericNHibernateDao(Of CccDatoGesAge, String)
            Implements IDatoGesAge

            Public Function GetByDatoGesAge(ByVal _ages As String) As List(Of CccDatoGesAge) Implements IDatoGesAge.GetByDatoGesAge
                Dim listDatoGesAge As IList
                Try
                    listDatoGesAge = NHibernateSession.GetNamedQuery("SelectDatoGesAge").SetString("age", _ages).List
                    If listDatoGesAge.Count > 0 Then
                        Return ConvertToGenericList(listDatoGesAge)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function





        End Class
        Public Function GetJuegosDao() As IJuegosDao Implements IDaoFactoryCcc.GetJuegosDao
            Return New JuegosDao
        End Function

        Public Class JuegosDao
            Inherits GenericNHibernateDao(Of Juegos, String)
            Implements IJuegosDao
            Public Function GetTodos(ByVal param1 As String) As List(Of Juegos) Implements IJuegosDao.GetTodos
                Dim Juegoslist As IList
                Try
                    Juegoslist = NHibernateSession.GetNamedQuery("SELECT_JUEGOS").SetString("param1", param1).List

                    If Juegoslist.Count > 0 Then
                        Return ConvertToGenericList(Juegoslist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function SetRegistraDao() As IRegistraDao Implements IDaoFactoryCcc.SetRegistraDao
            Return New CccRegistraLLamadaDao
        End Function
        Public Class CccRegistraLLamadaDao
            Inherits GenericNHibernateDao(Of CccRegistraLLamada, String)
            Implements IRegistraDao
            Public Function SetLla(IdCon As Integer, IdTipCon As Integer, TipCon As String, NomCon As String, NomU As String, tiplla As String, age As String, dur As String, UCrea As Integer) As List(Of CccRegistraLLamada) Implements IRegistraDao.SetLla
                Dim Reglist As IList
                Try
                    Reglist = NHibernateSession.GetNamedQuery("InsertLLa").SetInt32("IdCon", IdCon).SetInt32("IdTipCon", IdTipCon).SetString("TipCon", TipCon).SetString("NomCon", NomCon).SetString("NomU", NomU).SetString("TipLla", tiplla).SetString("age", age).SetString("dur", dur).SetInt32("UCrea", UCrea).List

                    If Reglist.Count > 0 Then
                        Return ConvertToGenericList(Reglist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

            Public Function SetReg(IdTMIC As Integer, IdLla As Integer, nota As String) As List(Of CccRegistraLLamada) Implements IRegistraDao.SetReg
                Dim Reglist As IList
                Try
                    Reglist = NHibernateSession.GetNamedQuery("InsertReg").SetInt32("IdTMIC", IdTMIC).SetInt32("IdLla", IdLla).SetString("nota", nota).List

                    If Reglist.Count > 0 Then
                        Return ConvertToGenericList(Reglist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetHisLLa() As ICccHisLLa Implements IDaoFactoryCcc.GetHisLLa
            Return New CccHisLLaDao
        End Function
        Public Class CccHisLLaDao
            Inherits GenericNHibernateDao(Of CccHisLLa, String)
            Implements ICccHisLLa
            Public Function GetByAge(AGE As String, TOP As String) As List(Of CccHisLLa) Implements ICccHisLLa.GetByAge
                Dim hist As IList
                Try
                    hist = NHibernateSession.GetNamedQuery("SelectHistLlaAge").SetString("age", AGE).SetString("top", TOP).List
                    If hist.Count > 0 Then
                        Return ConvertToGenericList(hist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetHisLLaAct() As ICccHisLLaAct Implements IDaoFactoryCcc.GetHisLLaAct
            Return New CccHisLLaActDao
        End Function
        Public Class CccHisLLaActDao
            Inherits GenericNHibernateDao(Of CccHisLlaAct, String)
            Implements ICccHisLLaAct
            Public Function GetByIdLla(idLla As Integer) As List(Of CccHisLlaAct) Implements ICccHisLLaAct.GetByIdLla
                Dim hist As IList
                Try
                    hist = NHibernateSession.GetNamedQuery("SelectHistLlaActAge").SetInt32("idlla", idLla).List
                    If hist.Count > 0 Then
                        Return ConvertToGenericList(hist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class
        Public Function GetGesUsuDao() As IGesUsuDao Implements IDaoFactoryCcc.GetGesUsuDao
            Return New GesUsuDao
        End Function
        Public Class GesUsuDao
            Inherits GenericNHibernateDao(Of GesUsu, String)
            Implements IGesUsuDao
            Public Function GetByUsu(Optional _usu As Integer = 0) As List(Of GesUsu) Implements IGesUsuDao.GetByUsu
                Dim GesUsulist As IList
                Try
                    If _usu = 0 Then
                        GesUsulist = NHibernateSession.GetNamedQuery("SelectGesUsu1").List
                    Else
                        GesUsulist = NHibernateSession.GetNamedQuery("SelectGesUsu2").SetInt32("usu", _usu).List
                    End If

                    If GesUsulist.Count > 0 Then
                        Return ConvertToGenericList(GesUsulist)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetEjecutivosDao() As IEjecutivosDao Implements IDaoFactoryCcc.GetEjecutivosDao
            Return New EjecutivosDao
        End Function
        Public Class EjecutivosDao
            Inherits GenericNHibernateDao(Of Ejecutivos, String)
            Implements IEjecutivosDao
            Public Function GetByEmp() As List(Of Ejecutivos) Implements IEjecutivosDao.GetByEmp
                Dim EjeList As IList
                Try
                    EjeList = NHibernateSession.GetNamedQuery("SelectEje").List
                    If EjeList.Count > 0 Then
                        Return ConvertToGenericList(EjeList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class

        Public Function GetAgeConDao() As IAgeConDao Implements IDaoFactoryCcc.GetAgeConDao
            Return New CccAgeConDao
        End Function
        Public Class CccAgeConDao
            Inherits GenericNHibernateDao(Of CccAgeCon, String)
            Implements IAgeConDao
            Public Function GetByAge(age As String) As List(Of CccAgeCon) Implements IAgeConDao.GetByAge
                Dim AgeConList As IList
                Try
                    AgeConList = NHibernateSession.GetNamedQuery("SelectAgeCon").SetString("age", age).List
                    If AgeConList.Count > 0 Then
                        Return ConvertToGenericList(AgeConList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class

        Public Function GetMotDao() As IMotDao Implements IDaoFactoryCcc.GetMotDao
            Return New CccMotDao
        End Function
        Public Class CccMotDao
            Inherits GenericNHibernateDao(Of CccMot, String)
            Implements IMotDao
            Public Function GetByTip(tip As Integer) As List(Of CccMot) Implements IMotDao.GetByTip
                Dim MotList As IList
                Try
                    MotList = NHibernateSession.GetNamedQuery("SelectMots").SetInt32("tip", tip).List
                    If MotList.Count > 0 Then
                        Return ConvertToGenericList(MotList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetIncDao() As IIncDao Implements IDaoFactoryCcc.GetIncDao
            Return New CccIncDao
        End Function
        Public Class CccIncDao
            Inherits GenericNHibernateDao(Of CccInc, String)
            Implements IIncDao
            Public Function GetByTipMot(tip As Integer, mot As Integer) As List(Of CccInc) Implements IIncDao.GetByTipMot
                Dim IncList As IList
                Try
                    IncList = NHibernateSession.GetNamedQuery("SelectIncs").SetInt32("tip", tip).SetInt32("Mot", mot).List
                    If IncList.Count > 0 Then
                        Return ConvertToGenericList(IncList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetConDao() As IConDao Implements IDaoFactoryCcc.GetConDao
            Return New CccConDao
        End Function
        Public Class CccConDao
            Inherits GenericNHibernateDao(Of CccCon, String)
            Implements IConDao
            Public Function GetByTipMotInc(tip As Integer, mot As Integer, Inc As Integer) As List(Of CccCon) Implements IConDao.GetByTipMotInc
                Dim ConList As IList
                Try
                    ConList = NHibernateSession.GetNamedQuery("SelectCons").SetInt32("tip", tip).SetInt32("Mot", mot).SetInt32("Inc", Inc).List
                    If ConList.Count > 0 Then
                        Return ConvertToGenericList(ConList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetTecnicosDao() As ITecnicosDao Implements IDaoFactoryCcc.GetTecnicosDao
            Return New TecnicosDao
        End Function
        Public Class TecnicosDao
            Inherits GenericNHibernateDao(Of Tecnicos, String)
            Implements ITecnicosDao
            Public Function GetByTec() As List(Of Tecnicos) Implements ITecnicosDao.GetByTec
                Dim TecList As IList
                Try
                    TecList = NHibernateSession.GetNamedQuery("SelectTec").List
                    If TecList.Count > 0 Then
                        Return ConvertToGenericList(TecList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetClasLotDao() As IClasLotDao Implements IDaoFactoryCcc.GetClasLotDao
            Return New ClasificacionesLotDao
        End Function
        Public Class ClasificacionesLotDao
            Inherits GenericNHibernateDao(Of ClasificacionesLot, String)
            Implements IClasLotDao

            Public Function GetByClas(tpclas As String) As List(Of ClasificacionesLot) Implements IClasLotDao.GetByClas
                Dim ClasList As IList
                Try
                    ClasList = NHibernateSession.GetNamedQuery("SelectClas").SetString("tpclas", tpclas).List
                    If ClasList.Count > 0 Then
                        Return ConvertToGenericList(ClasList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class

        Public Function GetProvDao() As IProvDao Implements IDaoFactoryCcc.GetProvDao
            Return New ProvinciasDao
        End Function
        Public Class ProvinciasDao
            Inherits GenericNHibernateDao(Of Provincias, String)
            Implements IProvDao

            Public Function GetByProv() As List(Of Provincias) Implements IProvDao.GetByProv
                Dim ProvList As IList
                Try
                    ProvList = NHibernateSession.GetNamedQuery("SelectPro").List
                    If ProvList.Count > 0 Then
                        Return ConvertToGenericList(ProvList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetMunDao() As IMunDao Implements IDaoFactoryCcc.GetMunDao
            Return New MunicipiosDao
        End Function
        Public Class MunicipiosDao
            Inherits GenericNHibernateDao(Of Municipios, String)
            Implements IMunDao
            Public Function GetByProv(codpro As Integer) As List(Of Municipios) Implements IMunDao.GetByProv
                Dim MunList As IList
                Try
                    MunList = NHibernateSession.GetNamedQuery("SelectMun").SetInt32("codpro", codpro).List
                    If MunList.Count > 0 Then
                        Return ConvertToGenericList(MunList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetSecDao() As ISecDao Implements IDaoFactoryCcc.GetSecDao
            Return New SectoresDao
        End Function
        Public Class SectoresDao
            Inherits GenericNHibernateDao(Of Sectores, String)
            Implements ISecDao
            Public Function GetByMun(codmun As Integer) As List(Of Sectores) Implements ISecDao.GetByMun
                Dim SecList As IList
                Try
                    SecList = NHibernateSession.GetNamedQuery("SelectSec").SetInt32("codmun", codmun).List
                    If SecList.Count > 0 Then
                        Return ConvertToGenericList(SecList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class

        Public Function GetEstConAgeDao() As IEstConAgeDao Implements IDaoFactoryCcc.GetEstConAgeDao
            Return New EstConAgeDao
        End Function
        Public Class EstConAgeDao
            Inherits GenericNHibernateDao(Of EstConAge, String)
            Implements IEstConAgeDao

            Public Function GetByEst() As List(Of EstConAge) Implements IEstConAgeDao.GetByEst
                Dim EstConList As IList
                Try
                    EstConList = NHibernateSession.GetNamedQuery("SelectEstCon").List
                    If EstConList.Count > 0 Then
                        Return ConvertToGenericList(EstConList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try

            End Function

        End Class

        Public Function GetCarDao() As ICarDao Implements IDaoFactoryCcc.GetCarDao
            Return New CarDao
        End Function
        Public Class CarDao
            Inherits GenericNHibernateDao(Of CccCarteras, String)
            Implements ICarDao

            Public Function GetByCod(tip As Integer, cod As Integer) As List(Of CccCarteras) Implements ICarDao.GetByCod
                Dim CarList As IList
                Try
                    CarList = NHibernateSession.GetNamedQuery("SelectCar").SetInt32("tip", tip).SetInt32("cod", cod).List
                    If CarList.Count > 0 Then
                        Return ConvertToGenericList(CarList)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class

        Public Function GetGenericComboDao() As IGenericComboDao Implements IDaoFactoryCcc.GetGenericComboDao
            Return New GenericComboDao
        End Function
        Public Class GenericComboDao
            Inherits GenericNHibernateDao(Of CccGenericCombo, String)
            Implements IGenericComboDao
            Public Function GetTipCon() As List(Of CccGenericCombo) Implements IGenericComboDao.GetTipCon
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("SelectTipCon").List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

            Public Function GetTMIC(tip As Integer, mot As Integer, inc As Integer, con As Integer) As List(Of CccGenericCombo) Implements IGenericComboDao.GetTMIC
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("SelectTMIC").SetInt32("tip", tip).SetInt32("mot", mot).SetInt32("inc", inc).SetInt32("con", con).List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

            Public Function GetAcuPer() As List(Of CccGenericCombo) Implements IGenericComboDao.GetAcuPer
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("SelectAcuPer").List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function

        End Class
        Public Function GetInfFinAgeDao() As IInfFinAgeDao Implements IDaoFactoryCcc.GetInfFinAgeDao
            Return New InfFinAgeDao
        End Function
        Public Class InfFinAgeDao
            Inherits GenericNHibernateDao(Of CccInfFinAge, String)
            Implements IInfFinAgeDao
            Public Function GetByage(age As String) As List(Of CccInfFinAge) Implements IInfFinAgeDao.GetByage
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("SelectInfFinAge").SetString("age", age).List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetGenericRegDao() As IGenericRegDao Implements IDaoFactoryCcc.GetGenericRegDao
            Return New GenericRegDao
        End Function
        Public Class GenericRegDao
            Inherits GenericNHibernateDao(Of CccGenericReg, String)
            Implements IGenericRegDao

            Public Function GetEnvioSolModAge(str1 As String, str2 As String, str3 As String) As List(Of CccGenericReg) Implements IGenericRegDao.GetEnvioSolModAge
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("EnvioSolModAge").SetString("str1", str1).SetString("str2", str2).SetString("str3", str3).List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
            Public Function GetEnvioAperturaTicket() As Object Implements IGenericRegDao.GetEnvioAperturaTicket
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("EnvioSolModAge").List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
        Public Function GetAcuLisDao() As IAcuLisDao Implements IDaoFactoryCcc.GetAcuLisDao
            Return New AcuLisDao
        End Function

        Public Class AcuLisDao
            Inherits GenericNHibernateDao(Of CccAcu, String)
            Implements IAcuLisDao
            Public Function GetAcuLis(agentes As String) As List(Of CccAcu) Implements IAcuLisDao.GetAcuLis
                Dim List As IList
                Try
                    List = NHibernateSession.GetNamedQuery("SelectAcuLis").SetString("param1", agentes).List
                    If List.Count > 0 Then
                        Return ConvertToGenericList(List)
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Dim logEr As New LogErrorWrite
                    logEr.WriteLog(Date.Now, ex.Message, ex.Source, "") 'logE.WriteLog(Date.Now,ex.Message,ex.Source,ex.StackTrace)

                    Dim EnviaErr As New EnvioMsj
                    EnviaErr.EnviarLogError("aqui va el usuario", System.Net.Dns.GetHostName, Date.Now, ex.Message, ex.Source, ex.StackTrace)
                    'Throw New Exception("Error en la consulta de gestores", ex)
                    Return Nothing
                End Try
            End Function
        End Class
#End Region

    End Class

End Namespace


