// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PodSecurityContext holds pod-level security attributes and common
    /// container settings. Some fields are also present in
    /// container.securityContext.  Field values of container.securityContext
    /// take precedence over field values of PodSecurityContext.
    /// </summary>
    public partial class Corev1PodSecurityContext
    {
        /// <summary>
        /// Initializes a new instance of the Corev1PodSecurityContext class.
        /// </summary>
        public Corev1PodSecurityContext()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1PodSecurityContext class.
        /// </summary>
        /// <param name="fsGroup">A special supplemental group that applies to
        /// all containers in a pod. Some volume types allow the Kubelet to
        /// change the ownership of that volume to be owned by the pod:
        ///
        /// 1. The owning GID will be the FSGroup 2. The setgid bit is set (new
        /// files created in the volume will be owned by FSGroup) 3. The
        /// permission bits are OR'd with rw-rw----
        ///
        /// If unset, the Kubelet will not modify the ownership and permissions
        /// of any volume.</param>
        /// <param name="runAsNonRoot">Indicates that the container must run as
        /// a non-root user. If true, the Kubelet will validate the image at
        /// runtime to ensure that it does not run as UID 0 (root) and fail to
        /// start the container if it does. If unset or false, no such
        /// validation will be performed. May also be set in SecurityContext.
        /// If set in both SecurityContext and PodSecurityContext, the value
        /// specified in SecurityContext takes precedence.</param>
        /// <param name="runAsUser">The UID to run the entrypoint of the
        /// container process. Defaults to user specified in image metadata if
        /// unspecified. May also be set in SecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence for that container.</param>
        /// <param name="seLinuxOptions">The SELinux context to be applied to
        /// all containers. If unspecified, the container runtime will allocate
        /// a random SELinux context for each container.  May also be set in
        /// SecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence for that container.</param>
        /// <param name="supplementalGroups">A list of groups applied to the
        /// first process run in each container, in addition to the container's
        /// primary GID.  If unspecified, no groups will be added to any
        /// container.</param>
        public Corev1PodSecurityContext(long? fsGroup = default(long?), bool? runAsNonRoot = default(bool?), long? runAsUser = default(long?), Corev1SELinuxOptions seLinuxOptions = default(Corev1SELinuxOptions), IList<long?> supplementalGroups = default(IList<long?>))
        {
            FsGroup = fsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            SupplementalGroups = supplementalGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a special supplemental group that applies to all
        /// containers in a pod. Some volume types allow the Kubelet to change
        /// the ownership of that volume to be owned by the pod:
        ///
        /// 1. The owning GID will be the FSGroup 2. The setgid bit is set (new
        /// files created in the volume will be owned by FSGroup) 3. The
        /// permission bits are OR'd with rw-rw----
        ///
        /// If unset, the Kubelet will not modify the ownership and permissions
        /// of any volume.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public long? FsGroup { get; set; }

        /// <summary>
        /// Gets or sets indicates that the container must run as a non-root
        /// user. If true, the Kubelet will validate the image at runtime to
        /// ensure that it does not run as UID 0 (root) and fail to start the
        /// container if it does. If unset or false, no such validation will be
        /// performed. May also be set in SecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence.
        /// </summary>
        [JsonProperty(PropertyName = "runAsNonRoot")]
        public bool? RunAsNonRoot { get; set; }

        /// <summary>
        /// Gets or sets the UID to run the entrypoint of the container
        /// process. Defaults to user specified in image metadata if
        /// unspecified. May also be set in SecurityContext.  If set in both
        /// SecurityContext and PodSecurityContext, the value specified in
        /// SecurityContext takes precedence for that container.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public long? RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets the SELinux context to be applied to all containers.
        /// If unspecified, the container runtime will allocate a random
        /// SELinux context for each container.  May also be set in
        /// SecurityContext.  If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes
        /// precedence for that container.
        /// </summary>
        [JsonProperty(PropertyName = "seLinuxOptions")]
        public Corev1SELinuxOptions SeLinuxOptions { get; set; }

        /// <summary>
        /// Gets or sets a list of groups applied to the first process run in
        /// each container, in addition to the container's primary GID.  If
        /// unspecified, no groups will be added to any container.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public IList<long?> SupplementalGroups { get; set; }

    }
}