using System.Diagnostics;
using UnityEngine;

namespace ProjectEssentials.Trace
{
    /// <summary>
    /// Utilis�e pour �crire plus facilement des logs
    /// uniquement dans l'�diteur ou sur un build en mode d�veloppement
    /// (Ne pas oublier de mettre le symbole dans Project Settings > Player > Scripting Define Symbols)
    /// </summary>
    public static class Trace
    {
        #region Constantes

        public const string ENABLE_LOGS_SYMBOL = "ENABLE_LOGS_IN_BUILD";

        #endregion

        #region Fonctions publiques

        /// <summary>
        /// Identique � Debug.Log, mais n'est compil�e que dans l'�diteur
        /// ou un build avec "ENABLE_LOGS" d�finie comme directive
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void Log(object msg)
        {
            UnityEngine.Debug.Log(msg);
        }

        /// <summary>
        /// Identique � Debug.Log
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        /// <param name="context">L'objet Unity � surligner pour indiquer la provenance du message</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void Log(object msg, Object context)
        {
            UnityEngine.Debug.Log(msg, context);
        }

        /// <summary>
        /// Identique � Debug.LogWarning
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void LogWarning(object msg)
        {
            UnityEngine.Debug.LogWarning(msg);
        }

        /// <summary>
        /// Identique � Debug.Log
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        /// <param name="context">L'objet Unity � surligner pour indiquer la provenance du message</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void LogWarning(object msg, Object context)
        {
            UnityEngine.Debug.LogWarning(msg, context);
        }

        /// <summary>
        /// Identique � Debug.LogError
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void LogError(object msg)
        {
            UnityEngine.Debug.LogError(msg);
        }

        /// <summary>
        /// Identique � Debug.Log
        /// </summary>
        /// <param name="msg">L'objet � afficher dans la console</param>
        /// <param name="context">L'objet Unity � surligner pour indiquer la provenance du message</param>
        [Conditional(ENABLE_LOGS_SYMBOL), Conditional("UNITY_EDITOR")]
        public static void LogError(object msg, Object context)
        {
            UnityEngine.Debug.LogError(msg, context);
        }

        #endregion
    }
}