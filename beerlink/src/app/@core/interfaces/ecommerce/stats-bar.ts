/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Personal / Commercial License.
 * See LICENSE_PERSONAL / LICENSE_COMMERCIAL in the project root for license information on type of purchased license.
 */

import { Observable } from 'rxjs';
import { AggregatedChartData } from '../common/chart';

export abstract class StatsBarData {
  abstract getStatsBarData(): Observable<AggregatedChartData>;
}
