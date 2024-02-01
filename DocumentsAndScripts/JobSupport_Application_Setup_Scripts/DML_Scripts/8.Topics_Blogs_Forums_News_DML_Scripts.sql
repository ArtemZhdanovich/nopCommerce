
-- use [onjobsupport47]

-- Topics Settings
UPDATE [dbo].[Topic] SET [Body] = '<p>Please contact us for any queries you have. We will be happy to assist you.</p>' WHERE Id=4 -- Contact us page
UPDATE [dbo].[Topic] SET [Body] = '<p></p>', Title='' WHERE Id=7 -- Login Page Info
UPDATE LocaleStringResource
SET ResourceValue='<p><strong>Welcome to on job support!</strong><br />Register with us for future convenience:</p><p style="text-align: left;">1.Resgistration is mandatory as we need to show relavent profiles to provide support and take support</p><p style="text-align: left;">2. You can directly contact with people who can provide support thus eliminating middle man</p><p style="text-align: left;">3. Please visit <a title="This Link" href="https://onjobsupport.in" target="_blank" rel="noopener">This Link</a> for further information</p>'
Where ResourceName='Account.Login.NewCustomerText'


-- hide footer Shipping & returns item
UPDATE [dbo].[Topic] SET IncludeInFooterColumn1=0 WHERE SystemName='ShippingInfo'


-- LoginPageContent Topic
INSERT INTO [dbo].[Topic]
           ([SystemName],[IncludeInSitemap],[IncludeInTopMenu],[IncludeInFooterColumn1]
		   ,[IncludeInFooterColumn2],[IncludeInFooterColumn3],[DisplayOrder],[AccessibleWhenStoreClosed]
           ,[IsPasswordProtected],[Title],[Body],[Published],[TopicTemplateId],[SubjectToAcl],[LimitedToStores])
     VALUES('LoginPageContent',0,0,0,0,0,1,0,0,'',
			'<div class="information-boxes-wrapper"> <div class="information-boxes-block"> <div class="information-box" href="abv.bg"> <div class="image-wrapper"> <div class="image-holder"> <img alt="" src="https://venture2.nop-templates.com/images/thumbs/0000442.png"> </div></div><div class="information-wrapper"> <div class="title">Why Choose Us</div></div><div class="information-wrapper"> <div class="description"> Lorem ipsum dolor sit amet, et mel quis habeo patrioque,eu eripuit menandri. Lorem ipsum dolor sit amet, et mel quis habeo patrioque,eu eripuit menandri. </div></div></div><div class="information-box"> <div class="image-wrapper"> <div class="image-holder"> <img alt="" src="https://venture2.nop-templates.com/images/thumbs/0000443.png"> </div></div><div class="information-wrapper"> <div class="title">100% Satisfaction Guaranteed</div></div><div class="information-wrapper"> <div class="description">Lorem ipsum dolor sit amet, et mel quis habeo patrioque.</div></div></div><div class="information-box"> <div class="image-wrapper"> <div class="image-holder"> <img alt="" src="https://venture2.nop-templates.com/images/thumbs/0000444.png"> </div></div><div class="information-wrapper"> <div class="title">100% Satisfaction Guaranteed</div></div><div class="information-wrapper"> <div class="description">Lorem ipsum dolor sit amet, et mel quis habeo patrioque.</div></div></div></div></div>'
			,1,1,0,0)