﻿export class LocationBreachModel  {
    latitude: number;
    longitude: number;

    hasLocationBoundry: boolean;
    locationBoundary: string;
    locationCount: number;
    locationTime: string;

    type: BreachType;

    createdAt: Date;

    hasEnded: boolean;
    endDate: Date;
}

export enum BreachType {
    None,
    Warning,
    Breach
}