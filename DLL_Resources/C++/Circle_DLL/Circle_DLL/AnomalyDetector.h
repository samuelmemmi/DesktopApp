#pragma once


#ifndef ANOMALYDETECTOR_H_
#define ANOMALYDETECTOR_H_

#include <string>
#include <vector>
#include "timeseries.h"
#include "math.h"
using namespace std;


class AnomalyReport {
public:
	//	const string description;
	//	const long timeStep;
	string circle;
	string description;
	long timeStep;

	AnomalyReport(string description, string circle, long timeStep) :description(description), circle(circle), timeStep(timeStep) {}
};


class TimeSeriesAnomalyDetector {
public:
	virtual void learnNormal(const TimeSeries& ts) = 0;
	virtual vector<AnomalyReport> detect(const TimeSeries& ts) = 0;
	virtual ~TimeSeriesAnomalyDetector() {}
};

#endif /* ANOMALYDETECTOR_H_ */

