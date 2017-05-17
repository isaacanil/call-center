Imports Core.Domain.CccEntidades
Namespace Core.DataInterfaces
    Public Interface IDaoFactoryCcc
        Function GetAgeDao() As IAgeDao 'Agentes
        Function GetDatoAgeDao() As IDatoAgeDao
        Function GetDatoGesAge() As IDatoGesAge
        Function GetJuegosDao() As IJuegosDao
        Function SetRegistraDao() As IRegistraDao
        Function GetHisLLa() As ICccHisLLa
        Function GetHisLLaAct() As ICccHisLLaAct
        Function GetGesUsuDao() As IGesUsuDao
        Function GetEjecutivosDao() As IEjecutivosDao
        Function GetAgeConDao() As IAgeConDao
        Function GetMotDao() As IMotDao
        Function GetIncDao() As IIncDao
        Function GetConDao() As IConDao
        Function GetTecnicosDao() As ITecnicosDao
        Function GetClasLotDao() As IClasLotDao
        Function GetProvDao() As IProvDao
        Function GetMunDao() As IMunDao
        Function GetSecDao() As ISecDao
        Function GetEstConAgeDao() As IEstConAgeDao
        Function GetCarDao() As ICarDao
        Function GetGenericComboDao() As IGenericComboDao
        Function GetInfFinAgeDao() As IInfFinAgeDao
        Function GetGenericRegDao() As IGenericRegDao
        Function GetAcuLisDao() As IAcuLisDao 'Lista de acuerdos..
    End Interface
#Region "Consulta_Avanzada"
    Public Interface IRegistraDao
        Inherits IGenericDao(Of CccRegistraLLamada, String)
        Function SetLla(ByVal IdCon As Integer, ByVal IdTipCon As Integer, ByVal TipCon As String, ByVal NomCon As String, ByVal NomU As String, ByVal TipLla As String, ByVal age As String, ByVal dur As String, ByVal UCrea As Integer) As List(Of CccRegistraLLamada)
        Function SetReg(ByVal IdTMIC As Integer, ByVal IdLla As Integer, ByVal nota As String) As List(Of CccRegistraLLamada)
    End Interface
    Public Interface IAgeDao
        Inherits IGenericDao(Of CccAge, String)
        Function GetByParam(ByVal _param1 As String, ByVal _param2 As String) As List(Of CccAge)
    End Interface
    Public Interface IDatoAgeDao
        Inherits IGenericDao(Of CccDatoAge, String)
        Function GetByAge(ByVal _age As String) As List(Of CccDatoAge)
    End Interface
    Public Interface IDatoGesAge
        Inherits IGenericDao(Of CccDatoGesAge, String)
        Function GetByDatoGesAge(ByVal _ages As String) As List(Of CccDatoGesAge)
    End Interface
    Public Interface IJuegosDao
        Inherits IGenericDao(Of Juegos, String)
        Function GetTodos(ByVal param1 As String) As List(Of Juegos)
    End Interface
    Public Interface ICccHisLLa
        Inherits IGenericDao(Of CccHisLLa, String)
        Function GetByAge(ByVal AGE As String, ByVal TOP As String) As List(Of CccHisLLa)
    End Interface
    Public Interface ICccHisLLaAct
        Inherits IGenericDao(Of CccHisLlaAct, String)
        Function GetByIdLla(ByVal idLla As Integer) As List(Of CccHisLlaAct)
    End Interface

    Public Interface IGesUsuDao
        Inherits IGenericDao(Of GesUsu, String)
        Function GetByUsu(Optional _usu As Integer = 0) As List(Of GesUsu)
    End Interface
    Public Interface IEjecutivosDao
        Inherits IGenericDao(Of Ejecutivos, String)
        Function GetByEmp() As List(Of Ejecutivos)
    End Interface
    Public Interface IAgeConDao
        Inherits IGenericDao(Of CccAgeCon, String)
        Function GetByAge(ByVal age As String) As List(Of CccAgeCon)
    End Interface
    Public Interface IMotDao
        Inherits IGenericDao(Of CccMot, String)
        Function GetByTip(ByVal tip As Integer) As List(Of CccMot)
    End Interface
    Public Interface IIncDao
        Inherits IGenericDao(Of CccInc, String)
        Function GetByTipMot(ByVal tip As Integer, ByVal mot As Integer) As List(Of CccInc)
    End Interface
    Public Interface IConDao
        Inherits IGenericDao(Of CccCon, String)
        Function GetByTipMotInc(ByVal tip As Integer, ByVal mot As Integer, ByVal Inc As Integer) As List(Of CccCon)
    End Interface
    Public Interface ITecnicosDao
        Inherits IGenericDao(Of Tecnicos, String)
        Function GetByTec() As List(Of Tecnicos)
    End Interface
    Public Interface IClasLotDao
        Inherits IGenericDao(Of ClasificacionesLot, String)
        Function GetByClas(ByVal tpclas As String) As List(Of ClasificacionesLot)
    End Interface
    Public Interface IProvDao
        Inherits IGenericDao(Of Provincias, String)
        Function GetByProv() As List(Of Provincias)
    End Interface
    Public Interface IMunDao
        Inherits IGenericDao(Of Municipios, String)
        Function GetByProv(ByVal codpro As Integer) As List(Of Municipios)
    End Interface
    Public Interface ISecDao
        Inherits IGenericDao(Of Sectores, String)
        Function GetByMun(ByVal codmun As Integer) As List(Of Sectores)
    End Interface
    Public Interface IEstConAgeDao
        Inherits IGenericDao(Of EstConAge, String)
        Function GetByEst() As List(Of EstConAge)
    End Interface
    Public Interface ICarDao
        Inherits IGenericDao(Of CccCarteras, String)
        Function GetByCod(tip As Integer, cod As Integer) As List(Of CccCarteras)
    End Interface
    Public Interface IGenericComboDao
        Inherits IGenericDao(Of CccGenericCombo, String)
        Function GetTipCon() As List(Of CccGenericCombo)
        Function GetTMIC(tip As Integer, mot As Integer, inc As Integer, con As Integer) As List(Of CccGenericCombo)
        Function GetAcuPer() As List(Of CccGenericCombo)
    End Interface
    Public Interface IInfFinAgeDao
        Inherits IGenericDao(Of CccInfFinAge, String)
        Function GetByage(age As String) As List(Of CccInfFinAge)
    End Interface

    Public Interface IGenericRegDao
        Inherits IGenericDao(Of CccGenericReg, String)
        Function GetEnvioSolModAge(str1 As String, str2 As String, str3 As String) As List(Of CccGenericReg)
        Function GetEnvioAperturaTicket()
    End Interface

    Public Interface IAcuLisDao
        Inherits IGenericDao(Of CccAcu, String)
        Function GetAcuLis(agentes As String) As List(Of CccAcu) 'recibe 0, 1 o varios agentes por ejemplo: '80353200','80353300'
    End Interface

#End Region

End Namespace

