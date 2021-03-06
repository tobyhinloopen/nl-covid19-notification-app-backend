﻿// Copyright © 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

using System.Linq;
using NL.Rijksoverheid.ExposureNotification.BackEnd.Components.EfDatabase;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.Components.RivmAdvice
{
    public class GetRivmAdviceContentCommand
    {
        private readonly IDbContextProvider<ExposureContentDbContext> _DbConfig;

        public GetRivmAdviceContentCommand(IDbContextProvider<ExposureContentDbContext> dbConfig)
        {
            _DbConfig = dbConfig;
        }

        public RivmAdviceContentEntity Execute(string id)
        {
            return _DbConfig.Current.Set<RivmAdviceContentEntity>()
                .SingleOrDefault(x => x.PublishingId == id);
        }
    }
}