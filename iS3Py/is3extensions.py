# Copyright (C) 2016 iS3 Software Foundation
# Author: Xiaojun Li
# Contact: xiaojunli@tongji.edu.cn

import sys
import clr
sys.path.append('extensions')
monlib = clr.LoadAssemblyFromFile('iS3.Monitoring.dll')
clr.AddReference(monlib)
from iS3.Monitoring import (MonitoringHelper, MonPoint,
                            MonGroup, MonReading)
