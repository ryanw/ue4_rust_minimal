// Fill out your copyright notice in the Description page of Project Settings.

#include "CityGameModeBase.h"
#include "float_test.h"

ACityGameModeBase::ACityGameModeBase() {
	float *floats;
	unsigned int floatCount = generate_floats(&floats);
	UE_LOG(LogTemp, Warning, TEXT("It begins"));

	for (size_t i = 0; i < floatCount; i++) {
		UE_LOG(LogTemp, Warning, TEXT("Got some data from rust land: %d - [%f]"), i, floats[i]);
	}
}
