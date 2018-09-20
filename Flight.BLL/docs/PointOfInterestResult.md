# IO.Swagger.Model.PointOfInterestResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | Display name of a given point of interest | 
**MainImage** | **string** | A link to an image of the given location | 
**Location** | [**Geolocation**](Geolocation.md) |  | 
**Grades** | [**PointOfInterestResultGrades**](PointOfInterestResultGrades.md) |  | 
**Categories** | **List&lt;string&gt;** | Array of descriptions indicating what type of point of interest this is. You can filter the results to include only certain categories of point of interest using the category input parameter. | 
**Details** | [**PointOfInterestDetails**](PointOfInterestDetails.md) |  | [optional] 
**ContextualImages** | [**List&lt;ImageSize&gt;**](ImageSize.md) | Images taken at this point of interest. Note that these images might have nothing to do with the point itself, particularly if you have enabled the social_media parameter | [optional] 
**GeonameId** | **int?** | The GeonamesID of this point of interest, if available | [optional] 
**WalkTime** | **decimal?** | Time in minutes that it takes to walk from the searched coordinates to this Point of Interest | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

