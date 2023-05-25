import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { Angulartics2GoogleTagManager } from 'angulartics2/gtm';
import { AppConsts } from '@shared/AppConsts';
import { UrlHelper } from '@shared/helpers/UrlHelper';
import { SubscriptionStartType } from '@shared/service-proxies/service-proxies';
import { ChatSignalrService } from 'app/shared/layout/chat/chat-signalr.service';
import { AppComponentBase } from 'shared/common/app-component-base';
import { LinkedAccountsModalComponent } from '@app/shared/layout/linked-accounts-modal.component';
import { UserDelegationsModalComponent } from '@app/shared/layout/user-delegations-modal.component';
import { ChangePasswordModalComponent } from '@app/shared/layout/profile/change-password-modal.component';
import { ChangeProfilePictureModalComponent } from '@app/shared/layout/profile/change-profile-picture-modal.component';
import { MySettingsModalComponent } from '@app/shared/layout/profile/my-settings-modal.component';
import { NotificationSettingsModalComponent } from '@app/shared/layout/notifications/notification-settings-modal.component';
import { UserNotificationHelper } from '@app/shared/layout/notifications/UserNotificationHelper';
import { DateTimeService } from './shared/common/timing/date-time.service';

@Component({
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.less'],
})
export class AppComponent extends AppComponentBase implements OnInit {
    subscriptionStartType = SubscriptionStartType;
    theme: string;
    installationMode = true;

    @ViewChild('linkedAccountsModal') linkedAccountsModal: LinkedAccountsModalComponent;
    @ViewChild('userDelegationsModal', { static: true }) userDelegationsModal: UserDelegationsModalComponent;
    @ViewChild('changePasswordModal', { static: true }) changePasswordModal: ChangePasswordModalComponent;
    @ViewChild('changeProfilePictureModal', { static: true })
    changeProfilePictureModal: ChangeProfilePictureModalComponent;
    @ViewChild('mySettingsModal', { static: true }) mySettingsModal: MySettingsModalComponent;
    @ViewChild('notificationSettingsModal', { static: true })
    notificationSettingsModal: NotificationSettingsModalComponent;
    @ViewChild('chatBarComponent') chatBarComponent;
    isQuickThemeSelectEnabled: boolean = this.setting.getBoolean('App.UserManagement.IsQuickThemeSelectEnabled');
    IsSessionTimeOutEnabled: boolean =
        this.setting.getBoolean('App.UserManagement.SessionTimeOut.IsEnabled') && this.appSession.userId != null;

    public constructor(
        injector: Injector,
        private _chatSignalrService: ChatSignalrService,
        private _userNotificationHelper: UserNotificationHelper,
        private _dateTimeService: DateTimeService,
        private _angulartics2GoogleTagManager: Angulartics2GoogleTagManager
    ) {
        super(injector);
        _angulartics2GoogleTagManager.startTracking();
    }

    ngOnInit(): void {
        this._userNotificationHelper.settingsModal = this.notificationSettingsModal;
        this.theme = abp.setting.get('App.UiManagement.Theme').toLocaleLowerCase();
        this.installationMode = UrlHelper.isInstallUrl(location.href);
        this.registerModalOpenEvents();

        // 20220104RBP - Disabling chat to avoid signalr errors in console.  We're not using it
        // if (this.appSession.application) {
        //     SignalRHelper.initSignalR(() => { this._chatSignalrService.init(); });
        // }
    }

    subscriptionStatusBarVisible(): boolean {
        return (
            this.appSession.tenantId > 0 &&
            (this.appSession.tenant.isInTrialPeriod || this.subscriptionIsExpiringSoon())
        );
    }

    subscriptionIsExpiringSoon(): boolean {
        if (this.appSession.tenant.subscriptionEndDateUtc) {
            let today = this._dateTimeService.getUTCDate();
            let daysFromNow = this._dateTimeService.plusDays(today, AppConsts.subscriptionExpireNootifyDayCount);
            return daysFromNow >= this.appSession.tenant.subscriptionEndDateUtc;
        }

        return false;
    }

    registerModalOpenEvents(): void {
        this.subscribeToEvent('app.show.linkedAccountsModal', () => {
            this.linkedAccountsModal.show();
        });

        this.subscribeToEvent('app.show.userDelegationsModal', () => {
            this.userDelegationsModal.show();
        });

        this.subscribeToEvent('app.show.changePasswordModal', () => {
            this.changePasswordModal.show();
        });

        this.subscribeToEvent('app.show.changeProfilePictureModal', () => {
            this.changeProfilePictureModal.show();
        });

        this.subscribeToEvent('app.show.mySettingsModal', () => {
            this.mySettingsModal.show();
        });
    }

    getRecentlyLinkedUsers(): void {
        abp.event.trigger('app.getRecentlyLinkedUsers');
    }

    onMySettingsModalSaved(): void {
        abp.event.trigger('app.onMySettingsModalSaved');
    }
}