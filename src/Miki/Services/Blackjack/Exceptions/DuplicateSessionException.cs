﻿namespace Miki.Services
{
    using Miki.Localization.Exceptions;
    using Miki.Localization.Models;

    public class DuplicateSessionException : LocalizedException
    {
        public override IResource LocaleResource 
            => new LanguageResource("error_blackjack_session_exists");
    }
}
