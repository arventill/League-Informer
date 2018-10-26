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
        ///   Looks up a localized string similar to \nSpróbuj ponownie później :).
        /// </summary>
        internal static string Common_TryAgainLater {
            get {
                return ResourceManager.GetString("Common_TryAgainLater", resourceCulture);
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
        ///   Looks up a localized string similar to Wystąpił nieznany błąd,spróbuj ponownie później.
        /// </summary>
        internal static string Error_Undefined {
            get {
                return ResourceManager.GetString("Error_Undefined", resourceCulture);
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
        ///   Looks up a localized string similar to 3. Wyjdź.
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
    }
}