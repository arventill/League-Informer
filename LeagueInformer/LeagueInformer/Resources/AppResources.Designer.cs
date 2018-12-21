﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueInformer.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LeagueInformer.Resources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to * * * Wciśnij dowolny klawisz aby kontynuować * * *.
        /// </summary>
        internal static string ClickToContinue {
            get {
                return ResourceManager.GetString("ClickToContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Wybrałeś opcję nr {1}.
        /// </summary>
        internal static string Common_ChosenOption {
            get {
                return ResourceManager.GetString("Common_ChosenOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Naciśnij ENTER, aby zakończyć działanie programu.
        /// </summary>
        internal static string Common_ExitApp {
            get {
                return ResourceManager.GetString("Common_ExitApp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wybrana opcja jest niedostępna.
        /// </summary>
        internal static string Common_OptionIsNotAvailable {
            get {
                return ResourceManager.GetString("Common_OptionIsNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}. {1}, {2} wygranych meczów, {3} przegranych meczów, {4}LP.
        /// </summary>
        internal static string Common_StatisticsPatten {
            get {
                return ResourceManager.GetString("Common_StatisticsPatten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \nSpróbuj ponownie później :).
        /// </summary>
        internal static string Common_TryAgainLater {
            get {
                return ResourceManager.GetString("Common_TryAgainLater", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1}.
        /// </summary>
        internal static string Common_TwoVerbatimStrings {
            get {
                return ResourceManager.GetString("Common_TwoVerbatimStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}. {1}.
        /// </summary>
        internal static string Common_TwoVerbatimStringWithDot {
            get {
                return ResourceManager.GetString("Common_TwoVerbatimStringWithDot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wystąpił błąd pobierania danych z serwerów Riot Games,spróbuj ponownie później.
        /// </summary>
        internal static string Error_DownloadingData {
            get {
                return ResourceManager.GetString("Error_DownloadingData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie znaleziono przywoływacza o podanym nicku.
        /// </summary>
        internal static string Error_PlayerNotFound {
            get {
                return ResourceManager.GetString("Error_PlayerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wybrany gracz nie posiada historii gier.
        /// </summary>
        internal static string Error_PlayerWithoutGamesHistory {
            get {
                return ResourceManager.GetString("Error_PlayerWithoutGamesHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ups!\nAplikacja nie może przetworzyć danych.
        /// </summary>
        internal static string Error_RequestAppError {
            get {
                return ResourceManager.GetString("Error_RequestAppError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upłynął czas przetwarzania żądania.\nPrawdopodobnie straciłeś połączenie z internetem lub serwery Riot nie odpowiadają.{0}.
        /// </summary>
        internal static string Error_RequestTimedOut {
            get {
                return ResourceManager.GetString("Error_RequestTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serwery Riot Games nie odpowiadają..
        /// </summary>
        internal static string Error_RiotServersAreDown {
            get {
                return ResourceManager.GetString("Error_RiotServersAreDown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nazwa przywoływacza nie może być pusta.
        /// </summary>
        internal static string Error_SummonerNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("Error_SummonerNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wystąpił nieznany błąd,spróbuj ponownie później.
        /// </summary>
        internal static string Error_Undefined {
            get {
                return ResourceManager.GetString("Error_Undefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gracz ma gorącą serię.
        /// </summary>
        internal static string GetBestMasters_HasHotStreak {
            get {
                return ResourceManager.GetString("GetBestMasters_HasHotStreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gracz nie ma gorącej serii.
        /// </summary>
        internal static string GetBestMasters_HasNotHotStreak {
            get {
                return ResourceManager.GetString("GetBestMasters_HasNotHotStreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gracz nie rozegrał ponad 100 gier w tej lidze.
        /// </summary>
        internal static string GetBestMasters_IsNotVeteran {
            get {
                return ResourceManager.GetString("GetBestMasters_IsNotVeteran", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gracz rozegrał ponad 100 gier w tej lidze.
        /// </summary>
        internal static string GetBestMasters_IsVeteran {
            get {
                return ResourceManager.GetString("GetBestMasters_IsVeteran", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj nazwe Przywoływacza: .
        /// </summary>
        internal static string GetLeagueOfSummoner_EnterName {
            get {
                return ResourceManager.GetString("GetLeagueOfSummoner_EnterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Wybierz z listy numer regionu, dla którego chcesz zobaczyć stan usług{1}.
        /// </summary>
        internal static string GetServerStatus_ChooseServerFromList {
            get {
                return ResourceManager.GetString("GetServerStatus_ChooseServerFromList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Dane dla serwera {1}{2}.
        /// </summary>
        internal static string GetServerStatus_DataForServer {
            get {
                return ResourceManager.GetString("GetServerStatus_DataForServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wystąpił błąd, prawdopodobnie wpisałeś nieprawidłową wartość, spróbuj jeszcze raz.
        /// </summary>
        internal static string GetServerStatus_ParsingFailed {
            get {
                return ResourceManager.GetString("GetServerStatus_ParsingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wpisz nazwe przywoływacza na serwerze EUNE: .
        /// </summary>
        internal static string GetSummonerGame_GiveSummonerNick {
            get {
                return ResourceManager.GetString("GetSummonerGame_GiveSummonerNick", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Przywoływacz aktualnie nie uczestniczy w żadnej rozgrywce.
        /// </summary>
        internal static string GetSummonerGame_SummonerDontPlay {
            get {
                return ResourceManager.GetString("GetSummonerGame_SummonerDontPlay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj nick przywoływacza:.
        /// </summary>
        internal static string GetSummonerLeagueInfo_GiveSummonerNick {
            get {
                return ResourceManager.GetString("GetSummonerLeagueInfo_GiveSummonerNick", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wybierz interesującą Cię funkcję:.
        /// </summary>
        internal static string Main_ChooseFunction {
            get {
                return ResourceManager.GetString("Main_ChooseFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aby używać aplikacji konieczne jest połączenie z internetem.
        ///Do zobaczenia!.
        /// </summary>
        internal static string Main_NoInternetConnection {
            get {
                return ResourceManager.GetString("Main_NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wyjdź.
        /// </summary>
        internal static string Main_Quit {
            get {
                return ResourceManager.GetString("Main_Quit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Witaj w League Informer!.
        /// </summary>
        internal static string Main_WelcomeUser {
            get {
                return ResourceManager.GetString("Main_WelcomeUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O aplikacji.
        /// </summary>
        internal static string MainManu_AboutApp {
            get {
                return ResourceManager.GetString("MainManu_AboutApp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Informacje o przywoływaczu na serwerze EUNE.
        /// </summary>
        internal static string MainMenu_GetLeagueOfSummoner {
            get {
                return ResourceManager.GetString("MainMenu_GetLeagueOfSummoner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zobacz statystyki 10 najlepszych Masterów na serwerze EUNE.
        /// </summary>
        internal static string MainMenu_GetMasterList {
            get {
                return ResourceManager.GetString("MainMenu_GetMasterList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sprawdź status usług wybranego serwera gry.
        /// </summary>
        internal static string MainMenu_GetServerStatus {
            get {
                return ResourceManager.GetString("MainMenu_GetServerStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sprawdź czy przywoływacz uczestniczy w rozgrywce.
        /// </summary>
        internal static string MainMenu_GetSummonerGame {
            get {
                return ResourceManager.GetString("MainMenu_GetSummonerGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pobierz informacje o lidze wybranego przywoływacza.
        /// </summary>
        internal static string MainMenu_GetSummonerLeagueInfo {
            get {
                return ResourceManager.GetString("MainMenu_GetSummonerLeagueInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Informacja: Aby wybrać nazwę z listy wpisz żądany numer.
        /// </summary>
        internal static string PrintListOfSavedNicknames_Information {
            get {
                return ResourceManager.GetString("PrintListOfSavedNicknames_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Wybierz nazwę przywoływacza z listy lub wpisz ją ręcznie:.
        /// </summary>
        internal static string PrintListOfSavedNicknames_Instruction {
            get {
                return ResourceManager.GetString("PrintListOfSavedNicknames_Instruction", resourceCulture);
            }
        }
    }
}
